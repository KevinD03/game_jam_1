using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float _playerSpeed = 15f;


    [SerializeField]
    private float _parallel_track_distance;

    private float _targetz;
    private bool _movingUp;

    [SerializeField]
    private float _z_increment;

    /*[SerializeField]
    private GameObject _peoplePrefab;*/

    [SerializeField]
    private peopleSpawnManager _peopleSpawnManager;

    [SerializeField]
    private UI_manager _uiManager;

    [SerializeField]
    private int _score;

    [SerializeField]
    private Lever _lever;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-20, 0, 0);
        _targetz = transform.position.z;
        _peopleSpawnManager = GameObject.Find("peopleSpawnManager").GetComponent<peopleSpawnManager>();
        _uiManager = GameObject.Find("UI_manager").GetComponent<UI_manager>();
        

        if (_peopleSpawnManager == null)
        {
            Debug.LogError("Spawn manager is null");
        }

        if (_uiManager == null)
        {
            Debug.LogError("UI manager is null");
        }

        // need to change direction when we arrive at a split, so watch for that
        EventManager.Sub( "NodeHit", HandleNodeCollision );
        EventManager.Sub("Kill", () => { addScore(1); });
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        //Debug.Log("Moving");
        transform.Translate(Vector3.forward * _playerSpeed * Time.deltaTime);

        if (_movingUp && _targetz > transform.position.z)
        {
            transform.Translate(new Vector3(0, 0, -_z_increment));
        }
        else if (!_movingUp && _targetz < transform.position.z)
        {
            transform.Translate(new Vector3(0, 0, _z_increment));
        }
    }

    void HandleNodeCollision( GameObject node )
    {
        Debug.LogFormat( "Touched node: {0}", node.name );
        TrainNode tn = node.GetComponent<TrainNode>();
        if (tn.splitUpwards)
        {
            if (_lever.GetState() ==  LeverState.Left)
            {
                Debug.Log("switch tracks upwards");
                _movingUp = true;
                _targetz = transform.position.z - _parallel_track_distance;
            }
        }
        else
        {
            if (_lever.GetState() == LeverState.Right)
            {
                _movingUp = false;
                _targetz = transform.position.z + _parallel_track_distance;
                Debug.Log("switch tracks downwards");
            }
        }
    }

    public void addScore(int score)
    {
        _score += score;
        Debug.Log(_score);
        _uiManager.updateScore(_score);
    }
}

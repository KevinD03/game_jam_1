using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float _playerSpeed = 15f;

    [SerializeField]
    private GameObject _peoplePrefab;

    [SerializeField]
    private peopleSpawnManager _peopleSpawnManager;

    [SerializeField]
    private UI_manager _uiManager;

    [SerializeField]
    private int _score;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-20, 0, 0);
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
        transform.Translate(Vector3.forward * _playerSpeed * Time.deltaTime);
    }

    void HandleNodeCollision( GameObject node )
    {
        Debug.LogFormat( "Touched node: {0}", node.name );
    }

    public void addScore(int score)
    {
        _score += score;
        Debug.Log(_score);
        _uiManager.updateScore(_score);
    }
}

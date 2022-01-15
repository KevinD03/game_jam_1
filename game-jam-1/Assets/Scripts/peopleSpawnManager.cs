using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peopleSpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _peopleContainer;

    [SerializeField]
    private GameObject[] _peoplePrefabs;

    private bool _gameEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnLocation1 = new Vector3(0, 0, 0);
        GameObject newVictim1 = Instantiate(_peoplePrefabs[UnityEngine.Random.Range(0, _peoplePrefabs.Length - 1)], spawnLocation1, Quaternion.identity);
        newVictim1.transform.parent = _peopleContainer.transform;





        /*StartCoroutine(spawnRoutine());*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

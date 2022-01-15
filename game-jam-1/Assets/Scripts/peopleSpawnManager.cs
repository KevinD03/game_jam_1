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
        Vector3 spawnLocation1 = new Vector3(54.43204f, 6f, -66.0695f);
        GameObject newVictim1 = Instantiate(_peoplePrefabs[UnityEngine.Random.Range(0, _peoplePrefabs.Length - 1)], spawnLocation1, Quaternion.identity);
        newVictim1.transform.parent = _peopleContainer.transform;

        Vector3 spawnLocation2 = new Vector3(54.43204f, 6f, -66.06955f);
        GameObject newVictim2 = Instantiate(_peoplePrefabs[UnityEngine.Random.Range(0, _peoplePrefabs.Length - 1)], spawnLocation1, Quaternion.identity);
        newVictim2.transform.parent = _peopleContainer.transform;

        
        Vector3 spawnLocation3 = new Vector3(54.43204f, 6f, -66.06955f);
        GameObject newVictim3 = Instantiate(_peoplePrefabs[UnityEngine.Random.Range(0, _peoplePrefabs.Length - 1)], spawnLocation1, Quaternion.identity);
        newVictim3.transform.parent = _peopleContainer.transform;

        Vector3 spawnLocation4 = new Vector3(54.43204f, 6.3f, -51.3f);
        GameObject newVictim4 = Instantiate(_peoplePrefabs[UnityEngine.Random.Range(0, _peoplePrefabs.Length - 1)], spawnLocation1, Quaternion.identity);
        newVictim4.transform.parent = _peopleContainer.transform;

        /*StartCoroutine(spawnRoutine());*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

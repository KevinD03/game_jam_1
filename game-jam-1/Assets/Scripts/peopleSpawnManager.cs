using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peopleSpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _peopleContainer;

    [SerializeField]
    private GameObject[] _peoplePrefabs;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnRoutine()
    {
        while (true)
        {
            // need to change
            Vector3 spawnLocation = new Vector3(0, 0, 0);
               
            // change num of people spawning
            for (int i = 0; i < Random.Range(0, 5); i++)
            {
                GameObject newVictim = Instantiate(_peoplePrefabs[UnityEngine.Random.Range(0, _peoplePrefabs.Length - 1)], spawnLocation, Quaternion.identity);
                newVictim.transform.parent = _peopleContainer.transform;
            }
            
            //GameObject newEnemy = Instantiate(_enemyPrefabs, spawnLocation, Quaternion.identity);
            
            yield return new WaitForSeconds(5.0f);
        }
    }
}

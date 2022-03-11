using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerOfEnemys : MonoBehaviour
{
    private float _timeBetweenSpawn;
    public float startTimeBetweenSpawn;
    public float discreaseTime;
    public float minDiscreasetime;

    public GameObject[] enemyObject;
  
    private void Update()
    {
        if (_timeBetweenSpawn <= 0)
        {
            var numbRandom = Random.Range(0, enemyObject.Length);
            
            Instantiate(enemyObject[numbRandom], transform.position, quaternion.identity);
            _timeBetweenSpawn = startTimeBetweenSpawn;

            if (startTimeBetweenSpawn > minDiscreasetime)
            {
                startTimeBetweenSpawn -= discreaseTime;
            }
        }
        else
        {
            _timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
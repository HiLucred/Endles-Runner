using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class SpawnerOfEnemys : MonoBehaviour
{
    private float _timeBetweenSpawn;
    public float startTimeBetweenSpawn;
    public float discreaseTime;
    public float minDiscreasetime;

    public GameObject[] enemyObject;

    public MovementEnemy movementEnemy;
    public float crementSpeed;
    public float maxCrementSpeed;

    private void Update()
    {
        //Se o tempo entre os spawns for 0, ou seja, está preparado para spawnar novamente
        if (_timeBetweenSpawn <= 0)
        {
            //Aleatoriamente escolhe um número de 0 a o tamanho de patterns
            var numbRandom = Random.Range(0, enemyObject.Length);
            
            //Em seguida spawna
            Instantiate(enemyObject[numbRandom], transform.position, quaternion.identity);
            
            //Aumenta a velocidade do movimento do inimigo
            if (movementEnemy.speedMovement < maxCrementSpeed)
            {
                movementEnemy.speedMovement += crementSpeed;    
            }
            
            //Adiciona uma contagem entre o tempo de spawn
            _timeBetweenSpawn = startTimeBetweenSpawn;
            
            //Se o tempo de spawn for menor do que o limite, diminui o tempo de spawn
            if (startTimeBetweenSpawn > minDiscreasetime)
            {
                startTimeBetweenSpawn -= discreaseTime;
            }
        }
        else
        {
            //Se já tiver sido adicionado uma contagem entre o tempo de spawn, faz que seu valor seja perdido
            //em relação ao tempo
            _timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
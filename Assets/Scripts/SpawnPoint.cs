using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject enemyObject;

    private void Start()
    {
        Instantiate(enemyObject, transform.position, Quaternion.identity);
    }
}
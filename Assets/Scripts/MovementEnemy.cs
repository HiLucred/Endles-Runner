using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    public float speedMovement = 2;

    private void Update()
    {
        transform.Translate(Vector2.left * speedMovement * Time.deltaTime);
    }

}
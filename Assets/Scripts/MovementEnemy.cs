using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    public float speedMovement = 2;
    
    public GameObject particleDeath;
    
    public GameObject soundDamage;

    private void Update()
    {
        transform.Translate(Vector2.left * speedMovement * Time.deltaTime);
    }

    public void DestroyEnemy()
    {
        ParticleOfBloodFromEnemy();
        SoundDamage();
        Destroy(gameObject, 0.1f);
    }

    private void ParticleOfBloodFromEnemy()
    {
        Instantiate(particleDeath, transform.position, quaternion.identity);
    }

    private void SoundDamage()
    {

        Instantiate(soundDamage, transform.position, quaternion.identity);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    private HealthManager _healthManager;
    [SerializeField] private int damageEnemy = 1;

    private void Awake()
    {
        _healthManager = FindObjectOfType<HealthManager>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            //Tomou Dano!
            _healthManager.TakeDamage(damageEnemy);
            Destroy(other.gameObject);
        }
    }
}
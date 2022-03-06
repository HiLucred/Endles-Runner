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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            _healthManager.TakeDamage(damageEnemy);
        }
    }
}

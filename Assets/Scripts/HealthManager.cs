using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    private int _maxHealth;
    [SerializeField] private int healthCurrent;

    [Header("UI")] 
    public Text healthUI;
    
    private void Start()
    {
        _maxHealth = 3;
        healthCurrent = _maxHealth;
    }

    private void Update()
    {
        RestartGame();
        UpdateDamageUI();
    }

    public void TakeDamage(int damage)
    {
        healthCurrent -= damage;
    }

    private void UpdateDamageUI()
    {
        healthUI.text = healthCurrent.ToString();
    }
    
    private void RestartGame()
    {
        if (healthCurrent <= 0)
        {
            //Game Over
            Debug.Log("Game Over");
            healthCurrent = 0;
        }
    }
}

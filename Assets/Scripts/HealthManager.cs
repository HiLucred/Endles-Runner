using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    private int _maxHealth;
    [SerializeField] private int healthCurrent;

    [Header("UI")] 
    public Text healthUI;

    public GameObject[] heartUI;
    
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
        if (healthCurrent == 3)
        {
            heartUI[0].SetActive(true);
            heartUI[1].SetActive(true);
            heartUI[2].SetActive(true);
        } else if (healthCurrent == 2)
        {
            heartUI[0].SetActive(true);
            heartUI[1].SetActive(true);
            heartUI[2].SetActive(false);
        } else if (healthCurrent == 1)
        {
            heartUI[0].SetActive(true);
            heartUI[1].SetActive(false);
            heartUI[2].SetActive(false);
        }
        else
        {
            heartUI[0].SetActive(false);
            heartUI[1].SetActive(false);
            heartUI[2].SetActive(false);
        }
    }
    
    private void RestartGame()
    {
        if (healthCurrent <= 0)
        {
            //Game Over
            SceneManager.LoadScene("Menu");
            Debug.Log("Game Over");
            healthCurrent = 0;
        }
    }
}

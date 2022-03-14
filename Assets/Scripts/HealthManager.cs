using System;
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
    public GameObject[] heartUI;
    public GameObject panelRestart;

    private MovementPlayer _movementPlayer;

    private void Awake()
    {
        _movementPlayer = FindObjectOfType<MovementPlayer>();
    }

    private void Start()
    {
        _maxHealth = 3;
        healthCurrent = _maxHealth;
        
        //Quando começa a Scene, o jogo volta a rodar
        //Time.timeScale = 1;
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
        //Switch para os corações da HUD desaparecerem conforme o estado da saúde
        //Saúde = 3 || 3 corações       Saúde = 2 || 2 corações         Saúde = 1 || 1 coração      ..

        switch (healthCurrent)
        {
            case 3:
                heartUI[0].SetActive(true);
                heartUI[1].SetActive(true);
                heartUI[2].SetActive(true);
                break;
            case 2:
                heartUI[0].SetActive(true);
                heartUI[1].SetActive(true);
                heartUI[2].SetActive(false);
                break;
            case 1:
                heartUI[0].SetActive(true);
                heartUI[1].SetActive(false);
                heartUI[2].SetActive(false);
                break;
            default:
                heartUI[0].SetActive(false);
                heartUI[1].SetActive(false);
                heartUI[2].SetActive(false);
                break;
        }
    }
    
    private void RestartGame()
    {
        if (healthCurrent <= 0)
        {
            //Abre painel de restart
            panelRestart.SetActive(true);
            _movementPlayer.gameObject.SetActive(false);
            //Pausa todas as ações do jogo (movimentação, animação e etc)
            //Time.timeScale = 0;
        }
    }
}

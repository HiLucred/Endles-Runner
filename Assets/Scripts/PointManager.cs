using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    //UI dos pontos ganhos no jogo
    public Text travelledDistanceUI;
    
    //Pontuação final de pontos ganhos no painel de Restart
    public Text pointsCollectdsUI;
    //Clone da pontuação final para dar efeito de sombra
    public Text pointsCollectdsUIShadow;
    
    //Variável que guarda a pontuação de pontos ganhos no jogo
    private float _travelledDistance;
    //Pontos ganhos a cada marca adquirida
    private float _distancePoints = 2f;

    private void Update()
    {
        travelledDistanceUI.text = _travelledDistance.ToString();
        
        pointsCollectdsUI.text = _travelledDistance.ToString();
        pointsCollectdsUIShadow.text = _travelledDistance.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Enemy")) return;
        
        //Adiciona ponto na HUD
        _travelledDistance += _distancePoints;
        
        //Depois de marcar ponto, destroi o inimigo
        Destroy(other.gameObject,1.5f);
    }
}

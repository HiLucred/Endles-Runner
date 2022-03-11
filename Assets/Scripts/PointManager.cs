using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public Text travelledDistanceUI;
    
    private float _travelledDistance;
    private float _distancePoints = 2f;

    private void Update()
    {
        //A todo instante muda a UI
        travelledDistanceUI.text = _travelledDistance.ToString();
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

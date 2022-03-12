using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class MovementPlayer : MonoBehaviour
{
    //Destino (Cima ou Baixo)
    private Vector2 _targetPos;
    
    public float yincrementMovement;
    public float speedMovement;
    
    //Limite até onde o jogador pode ir
    public float maxHeightMovement;
    public float minHeightMovement;

    public ParticleSystem particleMovement;

    private void Update()
    {
        MovePlayerPosition();
    }

    private void MovePlayerPosition()
    {
        //Mova suavemente para o destino
        transform.position = Vector2.MoveTowards(transform.position, _targetPos, speedMovement * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeightMovement)
        {
            //Mova para cima 
            _targetPos = new Vector2(transform.position.x, transform.position.y + yincrementMovement);
            particleMovement.Play();
        } 
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeightMovement)
        {
            //Mova para baixo 
            _targetPos = new Vector2(transform.position.x, transform.position.y - yincrementMovement);
            particleMovement.Play();
        }
    }
    
    
}

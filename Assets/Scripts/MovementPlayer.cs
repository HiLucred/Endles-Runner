using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class MovementPlayer : MonoBehaviour
{
    private Vector2 _targetPos;
    
    public float yincrementMovement;
    public float speedMovement;

    public float maxHeightMovement;
    public float minHeightMovement;

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
        } 
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeightMovement)
        {
            //Mova para baixo 
            _targetPos = new Vector2(transform.position.x, transform.position.y - yincrementMovement);
        }
    }
    
    
}

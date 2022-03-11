using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerPattern : MonoBehaviour
{
    //Script simples para não acoumular processamento desnecessária durante a jogatina
    private void Start()
    {
        Destroy(gameObject,1);
    }

}

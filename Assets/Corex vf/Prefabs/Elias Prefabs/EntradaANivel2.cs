using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntradaANivel2 : MonoBehaviour
{
    public GameObject ObjetoaTransportar;
    public Vector3 TeleportPos;
    public GameObject ObjetoDestino;

    void Start()
    {
        TeleportPos = ObjetoDestino.transform.position; 
    }

    public void OnTriggerEnter()
    {
        ObjetoaTransportar.transform.position = TeleportPos;
    }
    
    

}

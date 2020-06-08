using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntradaANivel2 : MonoBehaviour
{
    Vector3 TeleportPos;
    public GameObject ObjetoDestino;
    public CharacterController Personaje;

    void Awake()
    {
        Personaje = GameObject.Find("Personaje").GetComponent<CharacterController>();
    }
    void Start()
    {
        TeleportPos = new Vector3(101.533f, 11.742f, -27.12f);
        // TeleportPos = ObjetoDestino.transform.position; 
    }

    public void OnTriggerEnter(Collider col)
    {
        Personaje.enabled = false;
        col.transform.position = TeleportPos;
        Personaje.enabled = true;
    }



}

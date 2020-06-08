using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preguntar : MonoBehaviour
{
     void OnTriggerEnter(Collider other) {
        if (GameManager.sharedInstance_gm.currentGameState == GameState.inPlay)
        {
            GameMenuPreguntas.sharedInstance.MostrarPregunta(gameObject.name);
        }
    }
}

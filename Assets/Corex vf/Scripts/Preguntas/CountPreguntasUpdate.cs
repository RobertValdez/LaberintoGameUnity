using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountPreguntasUpdate : MonoBehaviour
{
    Text _Text;

    private void Awake() {
        _Text = GetComponent<Text>();
    }

    private void Update() {
        _Text.text = GameMenuPreguntas.sharedInstance.countRespuestasCorrectas +"/15";
    }
}

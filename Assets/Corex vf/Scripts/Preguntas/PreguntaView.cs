using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PreguntaView : MonoBehaviour
{
    public void OnClicBoton1()
    {
       // Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        GameMenuPreguntas.sharedInstance.ManagerRespuestas(1);
    }
    public void OnClicBoton2()
    {
        GameMenuPreguntas.sharedInstance.ManagerRespuestas(2);
    }
    public void OnClicBoton3()
    {
        GameMenuPreguntas.sharedInstance.ManagerRespuestas(3);
    }

    public void OnClicSalir()
    {
        GameMenuPreguntas.sharedInstance.MostrarCanvasPregunta(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PreguntaView : MonoBehaviour
{
    public void OnClicBoton1()
    {
       // Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        GameMenuPreguntas.sharedInstance.ManagerRespuestas(1, EventSystem.current.currentSelectedGameObject.name);
    }
    public void OnClicBoton2()
    {
        GameMenuPreguntas.sharedInstance.ManagerRespuestas(2, EventSystem.current.currentSelectedGameObject.name);
    }
    public void OnClicBoton3()
    {
        GameMenuPreguntas.sharedInstance.ManagerRespuestas(3, EventSystem.current.currentSelectedGameObject.name);
    }

    public void OnClicSalir()
    {
        GameMenuPreguntas.sharedInstance.MostrarCanvasPregunta(false);
    }
}

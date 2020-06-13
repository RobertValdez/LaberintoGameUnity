using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOpciones : MonoBehaviour
{

    public GameObject Obj;

    public Canvas OpcionesVolumen;
    public GameObject MenuInicio;
    void Start()
    {

        Obj.gameObject.SetActive(false);    
    }

    public void Salir()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void Carga()
    {
        GameManager.sharedInstance_gm.StartGame();
    }

    public void Onclick()
    {
        Obj.gameObject.SetActive(true);
    }

    public void Atras()
    {
        Obj.gameObject.SetActive(false);
    }

    public void HideOpcionesVolumen(){
        OpcionesVolumen.GetComponent<Canvas>().enabled = false;
        MenuInicio.SetActive(true);
    }

    public void ShowOpcionesVolumen()
    {
        OpcionesVolumen.GetComponent<Canvas>().enabled = true;
        MenuInicio.SetActive(false);
    }


}

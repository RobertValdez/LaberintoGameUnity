using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargarGanadores : MonoBehaviour
{
    Text _TextGanadores;

    public static CargarGanadores sharedInstance;
    
    private void Awake() {
        sharedInstance = this;
    }
    void Start()
    {
        Cargar();
    }

    public void Cargar(){
        _TextGanadores = GetComponent<Text>();
        string strGanadores = "";

        foreach (var item in GameManager.sharedInstance_gm.dictionaryBD)
        {
            strGanadores += item.Value + System.Environment.NewLine;
        }
        _TextGanadores.text = strGanadores;
    }
}

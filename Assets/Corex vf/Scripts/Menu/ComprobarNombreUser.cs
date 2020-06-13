using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComprobarNombreUser : MonoBehaviour
{
    public Text _TextName;
    public Text _TextNombreUso;
    public void Text_Changed(string newText)
    {
        _TextNombreUso.enabled = true;
        foreach (var item in GameManager.sharedInstance_gm.dictionaryBD)
        {
            if (item.Value == newText)
            {
                _TextNombreUso.text = "Nombre en uso, intente con otro.";
                _TextNombreUso.color = new Color32(253, 35, 35, 255);
            }
            else
            {
                _TextNombreUso.text = "Nombre disponible";
                _TextNombreUso.color = new Color32(37, 218, 224, 255);
            }
 
            if (newText == "")
            {
                _TextNombreUso.enabled = false;
            }  
        }
    }
}

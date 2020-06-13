using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComprobarNombreUser : MonoBehaviour
{
    public Text _TextName;
    public Text _TextNombreUso;

    string nameCapturado;
    public void Text_Changed(string newText)
    {
        if (GameManager.sharedInstance_gm.dictionaryBD.Count > 0)
        {
            _TextNombreUso.enabled = true;
            foreach (var item in GameManager.sharedInstance_gm.dictionaryBD)
            {
                if (item.Value == newText)
                {
                    GameManager.sharedInstance_gm.bolNameUser = false;
                    _TextNombreUso.text = "Nombre en uso, intente con otro.";
                    _TextNombreUso.color = new Color32(253, 35, 35, 255);
                    break;
                }
                else if(item.Value != newText)
                {
                    GameManager.sharedInstance_gm.bolNameUser = true;
                    _TextNombreUso.text = "Nombre disponible";
                    _TextNombreUso.color = new Color32(37, 218, 224, 255);
                }
                if (newText == "")
                {
                    GameManager.sharedInstance_gm.bolNameUser = false;
                    _TextNombreUso.enabled = false;
                    break;
                }
            }
        }
        else if(newText != "")
        {
            _TextNombreUso.enabled = true;
            GameManager.sharedInstance_gm.bolNameUser = true;

            _TextNombreUso.text = "Nombre disponible";
            _TextNombreUso.color = new Color32(37, 218, 224, 255);
        }
        else if (newText == "")
        {
            GameManager.sharedInstance_gm.bolNameUser = false;
            _TextNombreUso.enabled = false;
        }
    }
}

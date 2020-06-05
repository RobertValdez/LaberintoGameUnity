using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menupause : MonoBehaviour
{

    public void OnClicContinuar()
    {
       GameManagerPlaying.sharedInstance.QuitarPausa();
    }
    public void OnClicReiniciar()
    {
       GameManager.sharedInstance_gm.ReiniciarLevel1();
    }

    public void OnClicRegresarMenuInicio()
    {
        GameManager.sharedInstance_gm.RegresarMenuInicio();
    }

}
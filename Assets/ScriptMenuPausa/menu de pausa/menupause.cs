using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menupause : MonoBehaviour
{

    public void OnClicContinuar()
    {
        GameManager.sharedInstance_gm.QuitarPausa();
    }
    public void OnClicReiniciar()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnClicRegresarMenuInicio()
    {

    }

}
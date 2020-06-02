using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menupause : MonoBehaviour
{
    public GameObject menu;
    public static bool juegopausado;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegopausado == true)
            {
                quitarpausa();
            }
            else 
            {
                pausa();
            }
        }

    }
   
    void pausa()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
        juegopausado = true;

    }
    void quitarpausa()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
        juegopausado = false;
    }
    

}   


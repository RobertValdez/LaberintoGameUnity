using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance_gm;

    Canvas canvasMenuPausa;
    Camera camara;

    int oldMask;

    void Start()
    {
        if (sharedInstance_gm == null)
        {
            sharedInstance_gm = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
        buscarObjetos();
    }

    void buscarObjetos()
    {
        GameObject canvas = GameObject.Find("Menu de pausa");
        if (canvas != null)
        {
            canvasMenuPausa = canvas.GetComponent<Canvas>();
            Debug.Log(canvasMenuPausa.name);
            QuitarPausa();
        }

        GameObject cam = GameObject.Find("Camera");
        if (cam != null)
        {
            camara = cam.GetComponent<Camera>();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                MostrarMenu(true);
                oldMask = camara.cullingMask;
                Time.timeScale = 0;

                camara.clearFlags = CameraClearFlags.Nothing;
                camara.cullingMask = 0;
            }
            else
            {
                QuitarPausa();
            }
        }
    }

    public void QuitarPausa()
    {
        MostrarMenu(false);
        Time.timeScale = 1;

        camara.clearFlags = CameraClearFlags.Skybox;
        camara.cullingMask = oldMask;
    }

    void MostrarMenu(bool statePause)
    {
        canvasMenuPausa.enabled = statePause;
    }
}
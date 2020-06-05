using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerPlaying : MonoBehaviour
{
    public static GameManagerPlaying sharedInstance;

    private bool StatePause = false;

    //Comportamiento del estado Pausa
    Canvas canvasMenuPausa;
    Camera camara;
    int oldMask;

    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
    }
    private void Start()
    {
        AsignarObjects();
        canvasMenuPausa.enabled = false;
    }

    void AsignarObjects()
    {
        camara = GameObject.Find("Camera").GetComponent<Camera>();
        canvasMenuPausa = GameObject.FindGameObjectWithTag("PauseMenu").GetComponent<Canvas>();
    }

    void Update()
    {
        if (GameManager.sharedInstance_gm.currentGameState == GameState.inPlay)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (StatePause == false)
                {
                    PauseGame();
                }
                else
                {
                    QuitarPausa();
                }
            }
        }
    }

    private void PauseGame()
    {
        oldMask = camara.cullingMask;
        Time.timeScale = 0;

        camara.clearFlags = CameraClearFlags.Nothing;
        camara.cullingMask = 0;

        MostrarMenu(true);
        StatePause = true;
    }
    public void QuitarPausa()
    {
        Time.timeScale = 1;

        camara.clearFlags = CameraClearFlags.Skybox;
        camara.cullingMask = oldMask;

        MostrarMenu(false);
        StatePause = false;
    }

    void MostrarMenu(bool statePause)
    {
        canvasMenuPausa.enabled = statePause;
    }
}
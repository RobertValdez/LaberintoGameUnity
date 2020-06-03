using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    CameraClearFlags ClearFlags;
    public Camera camara;

    int oldMask;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                oldMask = camara.cullingMask;
                Time.timeScale = 0;

                camara.clearFlags = CameraClearFlags.Nothing;
                camara.cullingMask = 0;
            }
            else
            {
                Time.timeScale = 1;
                
                camara.clearFlags = CameraClearFlags.Skybox;
                camara.cullingMask = oldMask;
            }
        }
    }
}

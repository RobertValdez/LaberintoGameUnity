using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOpciones : MonoBehaviour
{
    
    public void Salir() {
        Application.Quit ();
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#endif
    }

    public void Carga() {
        GameManager.sharedInstance_gm.StartGame();
    }
}

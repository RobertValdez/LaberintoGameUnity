using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuOpciones : MonoBehaviour
{
    
    public void Salir() {
        Application.Quit ();
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#endif
    }

    public void Carga() {
        SceneManager.LoadScene("Level1");
    }
}

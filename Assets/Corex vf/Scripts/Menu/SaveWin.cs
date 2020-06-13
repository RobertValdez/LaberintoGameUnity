using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveWin : MonoBehaviour
{
    int countId = 0;
    private void OnTriggerExit(Collider collider) {
        if (collider.name == "Personaje")
        {
            countId = GameManager.sharedInstance_gm.countUserWuinId;

            countId++;
            WinSaveUser();
            Tiempo.sharedInstance.InGame = false;

            Destroy(gameObject);
        }
    }

    private void WinSaveUser()
    {
        PlayerPrefs.SetString("" + countId, PlayerPrefs.GetString("user"));
        GameManager.sharedInstance_gm.GenericsListKey();
    }
}

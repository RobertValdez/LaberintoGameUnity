using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveWin : MonoBehaviour
{
    int count = 0;
    private void OnTriggerEnter(Collider collider) {
        if (collider.name == "Personaje")
        {
            foreach (var item in GameManager.sharedInstance_gm.dictionaryBD)
            {
               count = System.Convert.ToInt32(item.Key);
               Debug.Log(item);
            }
            count++;
            WinSaveUser();
        }
    }

    private void WinSaveUser()
    {
        PlayerPrefs.SetString("" + count, PlayerPrefs.GetString("user"));
        GameManager.sharedInstance_gm.GenericsListKey();
    }
}

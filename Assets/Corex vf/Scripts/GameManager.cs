using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance_gm;
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
    }
}

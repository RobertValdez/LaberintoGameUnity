using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
    Text _Text;
    float timer;

    public bool InGame = true;
    public static Tiempo sharedInstance;

    private void Awake()
    {
        sharedInstance = this;
        _Text = GetComponent<Text>();
    }

    void Update()
    {
        if (InGame)
        {
            TimeActive();  
        }
    }
    
    private void TimeActive(){
        timer += Time.deltaTime;

        int min = (int)(timer / 60) % 60;
        int seg = (int)(timer % 60);

        string strTime = string.Format("{0:00}:{1:00}", min, seg);

        _Text.text = strTime;
    }
}

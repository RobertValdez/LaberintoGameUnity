using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
    Text _Text;
    float timer;
    private void Awake()
    {
        _Text = GetComponent<Text>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        int min = (int)(timer / 60) % 60;
        int seg = (int)(timer % 60);

        string strTime = string.Format("{0:00}:{1:00}", min, seg);

            _Text.text = strTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Musica : MonoBehaviour
{
    public static Musica sharedInstance;
    public bool inicioScene = false;

    void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
            DontDestroyOnLoad(this.gameObject);

            StartAudio();
        }
        else
        {
            Destroy(this);
        }
    }

     AudioSource m_MyAudioSource;
    void Start()
    {
         
    }

    public void StopAudio()
    { 
           m_MyAudioSource.Stop();           
    }
    public void StartAudio()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();
    }

}   

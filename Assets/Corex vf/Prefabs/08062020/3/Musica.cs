using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Musica : MonoBehaviour
{
    public bool inicioScene = false;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        Asignar();
    }
    public float volumen = 0.70f;
    AudioSource m_MyAudioSource;
    Slider slider;


    private void Asignar()
    {
        if (slider == null && SceneManager.GetActiveScene().name == "Menu")
        {
            slider = GameObject.Find("SliderVolumen0").GetComponent<Slider>();
            m_MyAudioSource = GetComponent<AudioSource>();

            if (GameManager.sharedInstance_gm.MusicVolSetting != 0)
            {
                slider.value = PlayerPrefs.GetFloat("VolumenMenu");
            }else
            {
                slider.value = volumen;
            }

            slider.onValueChanged.AddListener(delegate { SetVolume(slider.value); });
        }
    }

    private void Update()
    {
        Asignar();
        m_MyAudioSource.volume = volumen;
    }

    public void SetVolume(float vol)
    {
        volumen = vol;
        GameManager.sharedInstance_gm.MusicVolSetting = volumen;
    }

}

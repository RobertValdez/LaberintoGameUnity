using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenuPreguntas : MonoBehaviour
{
    public static GameMenuPreguntas sharedInstance;

    Canvas PreguntasSystem;
    Text PreguntaTitulo, PreguntaTxt, Resultado, Boton1Text, Boton2Text, Boton3Text;
    Button Boton1, Boton2, Boton3;

    Image Boton1img, Boton2img, Boton3img, ResultadoImg, pnlSalir;
    void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
        Asignar();
    }

    private void Start()
    {
        MostrarCanvasPregunta(false);
    }

    void Asignar()
    {
        PreguntaTitulo = GameObject.Find("PreguntaTitulo").GetComponent<Text>();
        PreguntaTxt = GameObject.Find("Pregunta_txt").GetComponent<Text>();

        Resultado = GameObject.Find("Resultado_txt").GetComponent<Text>();
        // ResultadoImg = GameObject.Find("Resultado_txt").GetComponent<Image>();

        Boton1Text = GameObject.Find("Boton1Text").GetComponent<Text>();
        Boton2Text = GameObject.Find("Boton2Text").GetComponent<Text>();
        Boton3Text = GameObject.Find("Boton3Text").GetComponent<Text>();

        Boton1 = GameObject.Find("Boton 1").GetComponent<Button>();
        Boton2 = GameObject.Find("Boton 2").GetComponent<Button>();
        Boton3 = GameObject.Find("Boton 3").GetComponent<Button>();

        Boton1img = GameObject.Find("Boton 1").GetComponent<Image>();
        Boton2img = GameObject.Find("Boton 2").GetComponent<Image>();
        Boton3img = GameObject.Find("Boton 3").GetComponent<Image>();

        pnlSalir = GameObject.Find("pnlSalir").GetComponent<Image>();
    }

    void Update()
    {
        /* if (Input.GetKeyDown(KeyCode.P))
        {
            
        } */

        if (secondViewCanvasPregunta)
        {
            secondCanvasPregunta += Time.deltaTime;
            int seg = (int)secondCanvasPregunta;

            if (seg >= 2)
            {
                secondViewCanvasPregunta = false;
                secondCanvasPregunta = 0;
                ResetCanvasPregunta();
                MostrarCanvasPregunta(false);
            }
        }
    }

    CapsuleCollider colMosaico;
    public void MostrarPregunta(string nombreMosaico)
    {
        colMosaico = GameObject.Find(nombreMosaico).GetComponent<CapsuleCollider>();

        switch (nombreMosaico)
        {
            case "Mosaico1":
                Pregunta_1();
                break;
            case "Mosaico2":
                Pregunta_2();
                break;
            case "Mosaico3":
                Pregunta_3();
                break;
            case "Mosaico4":
                Pregunta_4();
                break;
            case "Mosaico5":
                Pregunta_5();
                break;
            case "Mosaico6":
                Pregunta_6();
                break;
            case "Mosaico7":
                Pregunta_7();
                break;
            case "Mosaico8":
                Pregunta_8();
                break;
            case "Mosaico9":
                Pregunta_9();
                break;
            case "Mosaico10":
                Pregunta_10();
                break;
            case "Mosaico11":
                Pregunta_11();
                break;
            case "Mosaico12":
                Pregunta_12();
                break;
            case "Mosaico13":
                Pregunta_13();
                break;
            case "Mosaico14":
                Pregunta_14();
                break;
            case "Mosaico15":
                Pregunta_15();
                break;

            default:
                break;
        }
    }

    public void MostrarCanvasPregunta(bool show)
    {
        if (show)
        {
            gameObject.GetComponent<Canvas>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<Canvas>().enabled = false;
            pnlSalir.enabled = false;
        }
    }

    int vRespuestaCorrecta = 0;
    int PreguntaActual = 0;
    public void ManagerRespuestas(int botonClic)
    {                          
        switch (PreguntaActual)
        {
            case 1:
                Respuesta(botonClic);
                break;
            case 2:
                Respuesta(botonClic);
                break;
            case 3:
                Respuesta(botonClic);
                break;
            case 4:
                Respuesta(botonClic);
                break;
            case 5:
                Respuesta(botonClic);
                break;
            case 6:
                Respuesta(botonClic);
                break;
            case 7:
                Respuesta(botonClic);
                break;
            case 8:
                Respuesta(botonClic);
                break;
            case 9:
                Respuesta(botonClic);
                break;
            case 10:
                Respuesta(botonClic);
                break;
            case 11:
                Respuesta(botonClic);
                break;
            case 12:
                Respuesta(botonClic);
                break;
            case 13:
                Respuesta(botonClic);
                break;
            case 14:
                Respuesta(botonClic);
                break;
            case 15:
                Respuesta(botonClic);
                break;

            default:
                break;
        }
    }

    private void Pregunta_1()
    {
        PreguntaTxt.text = "¿Cómo se le llama a las computadoras de un solo usuario?";

        Boton1Text.text = "A) Mono Computadora";
        Boton2Text.text = "B) Macro Computadora";
        Boton3Text.text = "C) Ninguna es correcta"; //Correcta = 3

        vRespuestaCorrecta = 3;
        PreguntaActual = 1;
        MostrarCanvasPregunta(true);
    }

    private void Pregunta_2()
    {
        PreguntaTxt.text = "Elemento que ejecuta los procesos lógicos en la computadora:";

        Boton1Text.text = "A) Memoria RAM";
        Boton2Text.text = "B) Procesador"; //Correcta = 2
        Boton3Text.text = "C) Disco duro";

        vRespuestaCorrecta = 2;
        PreguntaActual = 2;
        MostrarCanvasPregunta(true);
    }
    private void Pregunta_3()
    {
        PreguntaTxt.text = "Características de un algoritmo:";

        Boton1Text.text = "A) Preciso, definido, finito";//Correcta = 1
        Boton2Text.text = "B) Completo, infinito, largo";
        Boton3Text.text = "C) Sencillo, rápido, corto";

        vRespuestaCorrecta = 1;
        PreguntaActual = 3;
        MostrarCanvasPregunta(true);
    }
    private void Pregunta_4()
    {
        PreguntaTxt.text = "¿Qué diagrama se usa para representar el código en la programación?";

        Boton1Text.text = "A) Diagrama de Flujo"; //Correcta = 1
        Boton2Text.text = "B) Diagrama Conceptual";
        Boton3Text.text = "C) Diagrama Floreal";

        vRespuestaCorrecta = 1;
        PreguntaActual = 4;
        MostrarCanvasPregunta(true);
    }
    private void Pregunta_5()
    {
        PreguntaTxt.text = "¿Sistema sobre el que está construido el código ASCII?";

        Boton1Text.text = "A) Hexadecimal";
        Boton2Text.text = "B) Binario";  //Correcta = 2
        Boton3Text.text = "C) Decimal";

        vRespuestaCorrecta = 2;
        PreguntaActual = 5;
        MostrarCanvasPregunta(true);
    }
    private void Pregunta_6()
    {
        PreguntaTxt.text = "";

        Boton1Text.text = "";
        Boton2Text.text = "";
        Boton3Text.text = ""; //Correcta

        vRespuestaCorrecta = 0;
        PreguntaActual = 0;
        // MostrarCanvasPregunta(true);
    }
    private void Pregunta_7()
    {
        PreguntaTxt.text = "";

        Boton1Text.text = "";
        Boton2Text.text = "";
        Boton3Text.text = ""; //Correcta

        vRespuestaCorrecta = 0;
        PreguntaActual = 0;
        // MostrarCanvasPregunta(true);
    }
    private void Pregunta_8()
    {
        PreguntaTxt.text = "";

        Boton1Text.text = "";
        Boton2Text.text = "";
        Boton3Text.text = ""; //Correcta

        vRespuestaCorrecta = 0;
        PreguntaActual = 0;
        //   MostrarCanvasPregunta(true);
    }
    private void Pregunta_9()
    {
        PreguntaTxt.text = "";

        Boton1Text.text = "";
        Boton2Text.text = "";
        Boton3Text.text = ""; //Correcta

        vRespuestaCorrecta = 0;
        PreguntaActual = 0;
        // MostrarCanvasPregunta(true);
    }
    private void Pregunta_10()
    {
        PreguntaTxt.text = "";

        Boton1Text.text = "";
        Boton2Text.text = "";
        Boton3Text.text = ""; //Correcta

        vRespuestaCorrecta = 0;
        PreguntaActual = 0;
        //  MostrarCanvasPregunta(true);
    }
    private void Pregunta_11()
    {
        PreguntaTxt.text = "";

        Boton1Text.text = "";
        Boton2Text.text = "";
        Boton3Text.text = ""; //Correcta

        vRespuestaCorrecta = 0;
        PreguntaActual = 0;
        //  MostrarCanvasPregunta(true);
    }
    private void Pregunta_12()
    {
        PreguntaTxt.text = "";

        Boton1Text.text = "";
        Boton2Text.text = "";
        Boton3Text.text = ""; //Correcta

        vRespuestaCorrecta = 0;
        PreguntaActual = 0;
        // MostrarCanvasPregunta(true);
    }
    private void Pregunta_13()
    {
        PreguntaTxt.text = "";

        Boton1Text.text = "";
        Boton2Text.text = "";
        Boton3Text.text = ""; //Correcta

        vRespuestaCorrecta = 0;
        PreguntaActual = 0;
        //  MostrarCanvasPregunta(true);
    }
    private void Pregunta_14()
    {
        PreguntaTxt.text = "";

        Boton1Text.text = "";
        Boton2Text.text = "";
        Boton3Text.text = ""; //Correcta

        vRespuestaCorrecta = 0;
        PreguntaActual = 0;
        //  MostrarCanvasPregunta(true);
    }
    private void Pregunta_15()
    {
        PreguntaTxt.text = "";

        Boton1Text.text = "";
        Boton2Text.text = "";
        Boton3Text.text = ""; //Correcta

        vRespuestaCorrecta = 0;
        PreguntaActual = 0;
        //   MostrarCanvasPregunta(true);
    }

    public int countRespuestasCorrectas;
    bool secondViewCanvasPregunta = false;
    float secondCanvasPregunta = 0;
    private void Respuesta(int botonClic)
    {
        PreguntaTitulo.enabled = false;
        PreguntaTxt.enabled = false;
        Resultado.enabled = true;
        pnlSalir.enabled = true;

        switch (botonClic)
        {
            case 1:
                vRespuestaBoton1();
                break;
            case 2:
                vRespuestaBoton2();
                break;
            case 3:
                vRespuestaBoton3();
                break;

            default:
                break;
        }

        Boton1.enabled = false;
        Boton2.enabled = false;
        Boton3.enabled = false;
        colMosaico.enabled = false;

        secondViewCanvasPregunta = true;
    }

    private void vRespuestaBoton1()
    {
        if (1 == vRespuestaCorrecta)
        {
            Boton1img.color = new Color32(20, 188, 25, 255); // Verde> Indica que fue una eleccion correcta

            Resultado.text = "Respuesta Correcta!!";
            Resultado.color = new Color32(20, 188, 25, 255); // Verde
            countRespuestasCorrectas++;
        }
        else if (2 == vRespuestaCorrecta) //Indica que fue una eleccion incorrecta, y evalua cual era la 
        //correcta para mostrarla en Verde y roja para mostrar en rojo el boton cliqueado
        {
            Boton2img.color = new Color32(20, 188, 25, 255); //Verde
            Boton1img.color = new Color32(192, 41, 56, 255); //Rojo

            Resultado.text = "Respuesta Incorrecta";
            Resultado.color = new Color32(192, 41, 56, 255); // Rojo
        }
        else if (3 == vRespuestaCorrecta)
        {
            Boton3img.color = new Color32(20, 188, 25, 255); // Verde
            Boton1img.color = new Color32(192, 41, 56, 255); //Rojo

            Resultado.text = "Respuesta Incorrecta";
            Resultado.color = new Color32(192, 41, 56, 255); // Rojo
        }
    }

    private void vRespuestaBoton2()
    {
        if (2 == vRespuestaCorrecta)
        {
            Boton2img.color = new Color32(20, 188, 25, 255); // Verde

            Resultado.text = "Respuesta Correcta!!";
            Resultado.color = new Color32(20, 188, 25, 255); // Verde
            countRespuestasCorrectas++;
        }
        else if (1 == vRespuestaCorrecta)
        {
            Boton1img.color = new Color32(20, 188, 25, 255); //Verde
            Boton2img.color = new Color32(192, 41, 56, 255); //Rojo

            Resultado.text = "Respuesta Incorrecta";
            Resultado.color = new Color32(192, 41, 56, 255); // Rojo
        }
        else if (3 == vRespuestaCorrecta)
        {
            Boton3img.color = new Color32(20, 188, 25, 255); // Verde
            Boton2img.color = new Color32(192, 41, 56, 255); //Rojo

            Resultado.text = "Respuesta Incorrecta";
            Resultado.color = new Color32(192, 41, 56, 255); // Rojo
        }
    }

    private void vRespuestaBoton3()
    {
        if (3 == vRespuestaCorrecta)
        {
            Boton3img.color = new Color32(20, 188, 25, 255); // Verde

            Resultado.text = "Respuesta Correcta!!";
            Resultado.color = new Color32(20, 188, 25, 255); // Verde
            countRespuestasCorrectas++;
        }
        else if (1 == vRespuestaCorrecta)
        {
            Boton1img.color = new Color32(20, 188, 25, 255); //Verde
            Boton3img.color = new Color32(192, 41, 56, 255); //Rojo

            Resultado.text = "Respuesta Incorrecta";
            Resultado.color = new Color32(192, 41, 56, 255); // Rojo
        }
        else if (2 == vRespuestaCorrecta)
        {
            Boton2img.color = new Color32(20, 188, 25, 255); // Verde
            Boton3img.color = new Color32(192, 41, 56, 255); //Rojo

            Resultado.text = "Respuesta Incorrecta";
            Resultado.color = new Color32(192, 41, 56, 255); // Rojo
        }
    }

    public void ResetCanvasPregunta()
    {
        PreguntaTitulo.enabled = true;
        PreguntaTxt.enabled = true;
        Resultado.enabled = false;

        Boton1.enabled = true;
        Boton2.enabled = true;
        Boton3.enabled = true;

        Boton1img.color = new Color32(255, 255, 255, 255);
        Boton2img.color = new Color32(255, 255, 255, 255);
        Boton3img.color = new Color32(255, 255, 255, 255);
    }
}

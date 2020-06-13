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
        PreguntaTxt.text = "Componente de una computadora que une todos sus componentes intercambiando la información entre ellos:";

        Boton1Text.text = "A) CPU";
        Boton2Text.text = "B) Disco Duro";
        Boton3Text.text = "C) Motherboard"; //Correcta = 3

        vRespuestaCorrecta = 3;
        PreguntaActual = 6;
        MostrarCanvasPregunta(true);
    }
    private void Pregunta_7()
    {
        PreguntaTxt.text = "¿Cuál es la principal diferencia entre RAM y ROM?";

        Boton1Text.text = "A) La ROM permite escritura de la información y la RAM no";
        Boton2Text.text = "B) La ROM está pensada para el almacenamiento permanente, y la RAM es para almacenamiento temporal"; //Correcta = 2
        Boton3Text.text = "C) La ROM está pensada para el almacenamiento temporal, y la RAM es para almacenamiento permanente"; 

        vRespuestaCorrecta = 2;
        PreguntaActual = 7;
        MostrarCanvasPregunta(true);
    }
    private void Pregunta_8()
    {
        PreguntaTxt.text = "Componente de un sistema en el que es guardado el “caché”:";

        Boton1Text.text = "A) CPU";
        Boton2Text.text = "B) RAM";//Correcta = 2
        Boton3Text.text = "C) Disco Duro"; 

        vRespuestaCorrecta = 2;
        PreguntaActual = 8;
        MostrarCanvasPregunta(true);
    }
    private void Pregunta_9()
    {
        PreguntaTxt.text = "¿Qué es el BIOS?";

        Boton1Text.text = "A) Es un software que reside en un chip instalado en la motherboard, revisa que no haya ningún problema de funcionamiento en los componentes";//Correcta = 1
        Boton2Text.text = "B) Es un software que se instala con el CPU, revisa que no haya ningún problema de funcionamiento en los componentes";
        Boton3Text.text = "C) Es un software que reside en un chip instalado en la motherboard, es una interfaz de configuración de administrador";

        vRespuestaCorrecta = 1;
        PreguntaActual = 9;
        MostrarCanvasPregunta(true);
    }
    private void Pregunta_10()
    {
        PreguntaTxt.text = "Principal diferencia entre RAM y NVRAM:";

        Boton1Text.text = "A) La NVRAM es capaz de sobrescribir información que recibe y la RAM sólo la lee";
        Boton2Text.text = "B) La NVRAM carga la configuración básica de funcionamiento del dispositivo y la RAM no";
        Boton3Text.text = "C) La NVRAM es capaz de almacenar información y no perderla al retirar la alimentación eléctrica, y la RAM es utilizada por un procesador para recibir instrucciones y guardar los resultados"; //Correcta = 3

        vRespuestaCorrecta = 3;
        PreguntaActual = 10;
        MostrarCanvasPregunta(true);
    }
    private void Pregunta_11()
    {
        PreguntaTxt.text = "Para que es una partición de disco";

        Boton1Text.text = "A) Para dividir un disco duro físico en varias partes"; //Correcta = 1
        Boton2Text.text = "B) Para borrar archivos";
        Boton3Text.text = "C) Instalar una aplicación"; 

        vRespuestaCorrecta = 1;
        PreguntaActual = 11;
        MostrarCanvasPregunta(true);
    }
    private void Pregunta_12()
    {
        PreguntaTxt.text = "¿Qué es una clase en programación?";

        Boton1Text.text = "A) Un algoritmo de ejecución";
        Boton2Text.text = "B) Es un modelo que define un conjunto de variables y métodos apropiados para operar con dichos datos";//Correcta = 2
        Boton3Text.text = "C) Una subrutina"; 

        vRespuestaCorrecta = 2;
        PreguntaActual = 12;
        MostrarCanvasPregunta(true);
    }
    private void Pregunta_13()
    {
        PreguntaTxt.text = "¿Qué es un método en programación?";

        Boton1Text.text = "A) Es un modelo que define un conjunto de variables y métodos apropiados para operar con dichos datos";
        Boton2Text.text = "B) Es un bloque de código que contiene una serie de instrucciones que pueden ser ejecutadas por un programa";//Correcta = 2
        Boton3Text.text = "C) Conjunto de datos"; 

        vRespuestaCorrecta = 2;
        PreguntaActual = 13;
        MostrarCanvasPregunta(true);
    }
    private void Pregunta_14()
    {
        PreguntaTxt.text = "¿Cuál de estos sirve para declarar una variable con punto decimal?";

        Boton1Text.text = "A) int";
        Boton2Text.text = "B) char";
        Boton3Text.text = "C) double"; //Correcta = 3

        vRespuestaCorrecta = 3;
        PreguntaActual = 14;
        MostrarCanvasPregunta(true);
    }
    private void Pregunta_15()
    {
        PreguntaTxt.text = "¿Cuál de las siguientes direcciones IP pertenece a una clase B?";

        Boton1Text.text = "A) 128.1.25.196";//Correcta = 1
        Boton2Text.text = "B) 98.23.81.1";
        Boton3Text.text = "C) 223.145.76.2";

        vRespuestaCorrecta = 1;
        PreguntaActual = 15;
        MostrarCanvasPregunta(true);
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

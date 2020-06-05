using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum Level
{
    Menu,
    Level1
}

public enum GameState
{
    menu,
    inPlay
}

public class GameManager : MonoBehaviour
{
    public GameState currentGameState = GameState.menu;
    public Level currentLevel = Level.Menu;
    public static GameManager sharedInstance_gm;

    private void Awake()
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

    void restoreScale(){
        Time.timeScale = 1; //Investigar razon de porque se reinicia en 0 el timeScale
    }

    public void StartGame()
    {
        SetGameState(GameState.inPlay);
        SceneManager.LoadScene("Level1");
    }

    public void ReiniciarLevel1(){
        SceneManager.LoadScene("Level1");
        restoreScale();
    }

    public void RegresarMenuInicio(){
        SetGameState(GameState.menu);
        SceneManager.LoadScene("Menu");
        restoreScale();
    }

    public void SetGameState(GameState newGameState)
    {
        if (newGameState == GameState.menu)
        {
            //No está relacionado con nada, pero es apropiado que exista
        }
        else if (newGameState == GameState.inPlay)
        {
            
        }
        this.currentGameState = newGameState;
    }
}
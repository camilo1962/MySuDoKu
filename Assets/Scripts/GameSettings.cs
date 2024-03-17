using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
   public enum EGameMode
    {
        NOT_SET,
        FACIL,
        MEDIO,
        DIFICIL,
        MUY_DIFICIL
    }

    public static GameSettings Instance;

    private void Awake()
    {
        _Paused = false;
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
            Destroy(this);
    }

    private EGameMode _GameMode;
    private bool _continuePreviousGame = false;
    private bool _exitAfterWon = false;
    private bool _Paused = false;

    
    public void SetExitAfterWon(bool set)
    {
        _exitAfterWon = set;
        _continuePreviousGame = false;
    }

    public bool GetExitAfterWon()
    {
        return _exitAfterWon;
    }

    public void SetContinuePreviousGame(bool continue_game)
    {
        _continuePreviousGame = continue_game;
    }

    public bool GetContinuePreviousGame()
    {
        return _continuePreviousGame;
    }


    public void SetPaused(bool paused) { _Paused = paused; }
    public bool GetPaused() { return _Paused; }

    void Start()
    {
        _GameMode = EGameMode.NOT_SET;
        _continuePreviousGame = false;
    }

    public void SetGameMode(EGameMode mode)
    {
        _GameMode = mode;
    }

    public void SetGameMode(string mode)
    {
        if (mode == "Fácil") SetGameMode(EGameMode.FACIL);
        else if (mode == "Medio") SetGameMode(EGameMode.MEDIO);
        else if (mode == "Difícil") SetGameMode(EGameMode.DIFICIL);
        else if (mode == "Muy Difícil") SetGameMode(EGameMode.MUY_DIFICIL);
        else SetGameMode(EGameMode.NOT_SET);
    }

    public string GetGameMode()
    {
        switch (_GameMode)
        {
            case EGameMode.FACIL: return "Fácil";
            case EGameMode.MEDIO: return "Medio";
            case EGameMode.DIFICIL: return "Difícil";
            case EGameMode.MUY_DIFICIL: return "Muy Difícil";
        }

        Debug.LogError("ERROR: Game Level is not set!");
        return " ";
    }
}

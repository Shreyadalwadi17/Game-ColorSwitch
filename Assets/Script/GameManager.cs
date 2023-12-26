using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum GameState
{
    MainMenu,
    GamePlay,
    GameOver,
    Pause
}
public class GameManager : MonoBehaviour
{
    public static GameManager inst;
    public static event Action<GameState> OnGameStateChanged;//EventAction
    public GameState curruntstate;

    void Awake()
    {
        inst = this;
    }


    public void UpdateGameState(GameState gs)
    {
        curruntstate = gs;
        OnGameStateChanged?.Invoke(gs);
    }

}







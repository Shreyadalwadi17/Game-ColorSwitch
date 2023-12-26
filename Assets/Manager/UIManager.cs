using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager inst;
    public List<screen> screenList;
    public screen currentScreen;

    private void Awake()
    {
        inst = this;
        //currentScreen = screenList[0];
    }
    private void Start()
    {
        // currentScreen.enabled = true;
        GameManager.inst.curruntstate = GameState.MainMenu;
    }

    public void ShowNextScreen(ScreenEnum ScreenType)
    {
        if (currentScreen != null)
            currentScreen.HideScreen();
        screenList[(int)ScreenType].ShowScreen();
        currentScreen = screenList[(int)ScreenType];

        switch (ScreenType)
        {
           
            case ScreenEnum.MainMenu:
                GameManager.inst.UpdateGameState(GameState.MainMenu);
                break;
            case ScreenEnum.GamePlay:
                GameManager.inst.UpdateGameState(GameState.GamePlay);
                break;
            case ScreenEnum.GameOver:
                GameManager.inst.UpdateGameState(GameState.GameOver);
                break;
            case ScreenEnum.Pause:
                GameManager.inst.UpdateGameState(GameState.Pause);
                break;
        }

    }
}




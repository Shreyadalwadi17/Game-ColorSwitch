using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ScreenEnum
{
    MainMenu,
    GamePlay,
    GameOver,
    Pause
   
}

public class screen : MonoBehaviour
{
    public ScreenEnum ScreenType;
    [HideInInspector] public Canvas currentCanvas;

    protected virtual void Awake()
    {
        currentCanvas = GetComponent<Canvas>();
    }

    public virtual void ShowScreen()
    {
        currentCanvas.enabled = true;
    }

    public virtual void HideScreen()
    {
        currentCanvas.enabled = false;
    }
}


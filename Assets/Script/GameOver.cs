using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : screen
{
  
 
    public void OnHomeButtonClick()
    {

        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        Ball.inst.spriterenderer.enabled = false;
        ScoreManager.inst.Reset();
    }
    public void OnTryButtonClick()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        Ball.inst.spriterenderer.enabled = false;
        Ball.inst.rigidbody2d.constraints = RigidbodyConstraints2D.None;
        SpawnRing.inst.Onreset();
        SpawnRing.inst.SetObjectsActive();
        ScoreManager.inst.Reset();

    }
}

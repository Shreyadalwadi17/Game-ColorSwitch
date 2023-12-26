using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : screen
{
    public void OnPlayButtonClick()
    {
        Time.timeScale = 1;
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        Ball.inst.spriterenderer.enabled = false;
        Ball.inst.rigidbody2d.isKinematic = false;
        Ball.inst.rigidbody2d.constraints = RigidbodyConstraints2D.None;

    }
    public void OnHomeeButtonClick()
    {

        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        Ball.inst.spriterenderer.enabled = false;
        SpawnRing.inst.Onreset();
        ScoreManager.inst.Reset();

    }
}

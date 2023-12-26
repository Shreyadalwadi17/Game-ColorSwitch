using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MainMenu : screen
{ 
  
    public static MainMenu inst;

    private void Start()
    {
        inst = this;
        UIManager.inst.ShowNextScreen(ScreenEnum.MainMenu);
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        ScoreManager.inst.Reset();

    }

    public void OnButtonClick()
    {
      
        Audio.inst.SoundPlay(Audio.SoundName.Buttons);
        UIManager.inst.ShowNextScreen(ScreenEnum.GamePlay);
        SpawnRing.inst.SetObjectsActive();
        Ball.inst.rigidbody2d.constraints = RigidbodyConstraints2D.None;
    }
   

   
   
}

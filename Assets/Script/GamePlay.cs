using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay :screen
{

    public static GamePlay inst;
   
    public void OnPauseButton()
    {
       // Time.timeScale = 0;
        UIManager.inst.ShowNextScreen(ScreenEnum.Pause);
        Ball.inst.rigidbody2d.isKinematic = true;
        Ball.inst.rigidbody2d.constraints = RigidbodyConstraints2D.FreezeAll;
        Ball.inst.spriterenderer.enabled = false;
    }
 
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour

{
    public int score = 0;
    public int highscore = 0;
    public Text scoretxt;
    public Text gameOverscore;
    public Text bestscore;
    public static ScoreManager inst;

    private void Awake()
    {
        Ball.inst.spriterenderer.enabled = true;
        inst = this;
        scoretxt.text = PlayerPrefs.GetInt("score", 0).ToString();
        bestscore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
    }
    public void IncreseScore(int value)
    {
        score = score + value;
        scoretxt.text = score.ToString();
        gameOverscore.text = score.ToString();

        if (score > highscore)
        highscore = score;
        bestscore.text = score.ToString();

    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        scoretxt.text = "0";


    }


}
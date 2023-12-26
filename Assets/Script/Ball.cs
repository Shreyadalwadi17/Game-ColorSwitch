using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Ball : MonoBehaviour
{

    public colorType ballenum;
    public static Ball inst;
    public Rigidbody2D rigidbody2d;
    public SpriteRenderer spriterenderer;
    public ColorManager colorManager;
    public ParticleSystem part;
    public GameObject ball;
    public static Action action;



    void Start()
    {
        
        inst = this;
        spriterenderer.enabled = false;
        spriterenderer = GetComponent<SpriteRenderer>();
   
    }
    private void OnEnable()
    {
        GameManager.OnGameStateChanged += OnStateChanged;
    }



    void Update()
    {
       
        action?.Invoke();

    }

    public void BallJump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spriterenderer.enabled = true;
           rigidbody2d.isKinematic = false;
            Audio.inst.SoundPlay(Audio.SoundName.Shoot);
            rigidbody2d.velocity = Vector2.up * 3;
            //GamePlay.inst.pptTxt.enabled = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("part"))
        {
           
            if (ballenum == collision.GetComponent<Part>().colorType)
            {
                Debug.Log("ball match");
            }
            else
            {

                part.Play();
                Debug.Log("partical play");

                StartCoroutine(enumerator());
                Debug.Log("wait 2 second");
                Debug.Log("color" + collision.GetComponent<Part>().colorType);

                spriterenderer.enabled = false;
                rigidbody2d.isKinematic = true;
                rigidbody2d.constraints = RigidbodyConstraints2D.FreezeAll;
                //UIManager.inst.ShowNextScreen(ScreenEnum.GameOver);
                Debug.Log("ball not match");  
               
            }
        }

        else if (collision.gameObject.CompareTag("star"))
        {
            ScoreManager.inst.IncreseScore(1);
            PlayerPrefs.SetInt("score", ScoreManager.inst.score);
            PlayerPrefs.SetInt("highscore", ScoreManager.inst.highscore);
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.CompareTag("colorchange"))
        {
            Audio.inst.SoundPlay(Audio.SoundName.ColorChange);
            Debug.Log("name" + collision.gameObject.name);
            //colorManager.ColorChange();

            collision.gameObject.GetComponent<ColorManager>().ColorChange();

            spriterenderer.color = collision.gameObject.GetComponent<ColorManager>().mycolor;
            ballenum = collision.gameObject.GetComponent<ColorManager>().currentcolor;
   
            Debug.Log("change color" + spriterenderer.color);
         
        }
        if(collision.gameObject.CompareTag("hand"))
        {
         rigidbody2d.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        

    }
    IEnumerator enumerator()
    {
        yield return new WaitForSeconds(1);
        UIManager.inst.ShowNextScreen(ScreenEnum.GameOver);
        Debug.Log("gameover screen");
        SpawnRing.inst.Onreset();
   
    }
    public void OnStateChanged(GameState gs)
    {
        switch (gs)
        {

            case GameState.MainMenu:
                action -= BallJump;
                break;
            case GameState.GamePlay:
                action += BallJump;
                break;
            case GameState.GameOver:
                action -= BallJump;
                break;
            case GameState.Pause:
                action -= BallJump;
                break;


        }
    }



}




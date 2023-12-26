using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class SpawnRing : MonoBehaviour
{
    public List<GameObject> parentList;
    public List<GameObject> spwanList;
    public GameObject spwanPoint;
    public static SpawnRing inst;
    public static Action edAction;


    private void Awake()
    {
        inst = this;
    }
   public  void OnEnable()
    {
        GameManager.OnGameStateChanged += OnStateChanged;
    }
  

    public void OnPauseButtonClick()
    {
        UIManager.inst.ShowNextScreen(ScreenEnum.Pause);

    }
    public void SetObjectsActive()
    {
        for (int i = 0; i < parentList.Count; i++)
        {
            GameObject random = Instantiate(parentList[Random.Range(0, parentList.Count)]);
            random.transform.position = RandomSpwanPoint();
            spwanList.Add(random);
        }


    }
    public Vector2 RandomSpwanPoint()
    {
        float xvalue = Random.Range(0f, 0f);
        float yvalue = Random.Range(6f, 6f);
        spwanPoint.transform.position = new Vector2(spwanPoint.transform.position.x + xvalue, spwanPoint.transform.position.y + yvalue);
        return spwanPoint.transform.position;

    }
    public void Onreset()
    {
        for (int i = 0; i < spwanList.Count; i++)
        {
            Destroy(spwanList[i].gameObject);

        }
        spwanList.Clear();
        spwanPoint.transform.position = new Vector3(0, 0, 0);
        Ball.inst.ball.transform.position = new Vector3(0, -1, 0);
        //Debug.Log("reset" + transform.position);

    }
    public void OnStateChanged(GameState gs)
    {
        switch (gs)
        {
            
            case GameState.MainMenu:
                edAction -= SetObjectsActive;
                break;
            case GameState.GamePlay:
                edAction += SetObjectsActive;
                break;
            case GameState.GameOver:
                edAction -= SetObjectsActive;
                break;
            case GameState.Pause:
                edAction -= SetObjectsActive;
                break;


        }
    }

}

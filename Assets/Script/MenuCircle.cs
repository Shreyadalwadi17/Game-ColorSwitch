using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCircle : MonoBehaviour
{
    public float speed = 40f;
    public List<GameObject> menucircleList;
  


    public void Update()
    {

       
            for (int i = 0; i < menucircleList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    menucircleList[i].transform.Rotate(0f, 0f, speed * Time.deltaTime);
                }
                else
                {
                    menucircleList[i].transform.Rotate(0f, 0f, -speed * Time.deltaTime);
                }
            }
        }


    }



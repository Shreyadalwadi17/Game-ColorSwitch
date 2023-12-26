using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed=2;
    private void Update()
    {
        transform.Rotate(0f, 0f, 5f*speed);
    }
}

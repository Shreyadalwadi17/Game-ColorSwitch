using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float offset;
    public void Start()
    {
        offset = transform.position.y;
    }

    private void LateUpdate()
    {
        transform.position= new Vector3(transform.position.x, Ball.inst.ball.transform.position.y , transform.position.z);
    }
}
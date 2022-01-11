using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningAroundScript : MonoBehaviour
{
    private float speed = 0.2f;
    private float minRotation = 200;
    private float maxRotation = 320;

    void Update()
    {
        float rotate = Mathf.SmoothStep(minRotation, maxRotation, Mathf.PingPong(Time.time * speed, 1));
        transform.rotation = Quaternion.Euler(0, rotate, 0);
    }
}

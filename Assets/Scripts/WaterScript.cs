using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    private float yPos;
    private float waveSpeed;

    void Start()
    {
        if (gameObject.name == "Waves_front_1")
        {
            yPos = -4.75f;
            waveSpeed = -0.125f;
        }
        if (gameObject.name == "Waves_front_2")
        {
            yPos = -4.7f;
            waveSpeed = -0.11f;
        }
        if (gameObject.name == "Waves_back_1")
        {
            yPos = -3.65f;
            waveSpeed = 0.1f;
        }
        if (gameObject.name == "Waves_back_2")
        {
            yPos = -2.8f;
            waveSpeed = 0.05f;
        }
        if (gameObject.name == "Waves_back_3")
        {
            yPos = -2f;
            waveSpeed = 0.027f;
        }
    }

    private void FixedUpdate()
    {
        float y = Mathf.PingPong(Time.time * waveSpeed, 0.7f) + yPos;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    private void FixedUpdate()
    {
        float y = Mathf.PingPong(Time.time * 0.2f, 0.7f) - 4.75f;

      //  float y = Mathf.PingPong(Time.time * speed, 1) * 6 - 3;

        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}

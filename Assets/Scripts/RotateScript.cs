using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    private int rotationModifier = 1;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "BritishFlag")
        {
            rotationModifier *= -1;
        }
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, 0.5f * rotationModifier, 0);
    }
}

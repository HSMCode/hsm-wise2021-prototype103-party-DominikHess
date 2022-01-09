using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Movement passengerScript;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<BoxCollider>().enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<BoxCollider>().enabled = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        passengerScript = GameObject.FindGameObjectWithTag("Passenger").GetComponent<Movement>();
        passengerScript.destroyPassenger(collision);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Movement passengerScript;
    public AudioClip[] shootSounds;
    private int random;

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
            playShootSound();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<BoxCollider>().enabled = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Patriot")
        {
            passengerScript = GameObject.FindGameObjectWithTag("Patriot").GetComponent<Movement>();
        }
        else
        {
            passengerScript = GameObject.FindGameObjectWithTag("Passenger").GetComponent<Movement>();
        }   
        passengerScript.destroyPassenger(collision);
    }

    private void playShootSound()
    {
        random = Random.Range(0, 2);
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = shootSounds[random];
        audio.Play();
    }

}

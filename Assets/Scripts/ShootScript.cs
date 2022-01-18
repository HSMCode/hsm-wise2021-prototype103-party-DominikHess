using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Movement passengerScript;
    public AudioClip[] shootSounds;
    private AudioSource audio;
    private Animator animator;
    private int random;
    private float lastTimePressed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider>().enabled = false;
        audio = GetComponent<AudioSource>();
        animator = GameObject.Find("Musket_Pivot").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > lastTimePressed + 1.5f)
        {
            animator.Play("ShootAnimation", 0, 0.25f);
            GetComponent<BoxCollider>().enabled = true;
            playShootSound();
            ParticleSystem smokeParticleSystem = GetComponent<ParticleSystem>();
            smokeParticleSystem.Play();
            lastTimePressed = Time.time;
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
        random = Random.Range(0, 3);  
        audio.clip = shootSounds[random];
        audio.Play();
    }
}

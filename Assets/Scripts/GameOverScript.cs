using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }

    void Update()
    {
        if (Input.anyKey && !audio.isPlaying)
        {
            FindObjectOfType<GameManagerScript>().ReturnToMainMenu();
        }
    }
}

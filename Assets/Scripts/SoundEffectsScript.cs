using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsScript : MonoBehaviour
{
    public AudioClip failSound;
    public AudioClip successSound;

    public void playFailSound()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = failSound;
        audio.Play();
    }

    public void playSuccessSound()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = successSound;
        audio.Play();
    }
}

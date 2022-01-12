using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void playButton()
    {
        audio.Play();
        Invoke("play", audio.clip.length);
    }
    public void mainMenuButton()
    {
        audio.Play();
        Invoke("mainMenu", audio.clip.length);
    }
    public void howToPlayButton()
    {
        audio.Play();
        Invoke("howToPlay", audio.clip.length);
    }
    public void creditsButton()
    {
        audio.Play();
        Invoke("credits", audio.clip.length);
    }

    private void play()
    {
        FindObjectOfType<GameManagerScript>().StartLevel01();
    }
    private void mainMenu()
    {
        FindObjectOfType<GameManagerScript>().ReturnToMainMenu();
    }
    private void howToPlay()
    {
        FindObjectOfType<GameManagerScript>().ShowHowToPlay();
    }
    private void credits()
    {
        FindObjectOfType<GameManagerScript>().ShowCredits();
    }
}

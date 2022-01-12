using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    private GameManagerScript gameManagerScript;
    private float delay = 1f;

    void Start()
    {
        gameManagerScript = FindObjectOfType<GameManagerScript>();
    }

    public void playButton()
    {
        gameManagerScript.playButtonSound();
        Invoke("play", delay);
    }

    public void mainMenuButton()
    {
        gameManagerScript.playButtonSound();
        Invoke("mainMenu", delay);
    }
    public void howToPlayButton()
    {
        gameManagerScript.playButtonSound();
        Invoke("howToPlay", delay);
    }
    public void creditsButton()
    {
        gameManagerScript.playButtonSound();
        Invoke("credits", delay);
    }

    private void play()
    {
        gameManagerScript.StartLevel01();
    }
    private void mainMenu()
    {
        gameManagerScript.ReturnToMainMenu();
    }
    private void howToPlay()
    {
        gameManagerScript.ShowHowToPlay();
    }
    private void credits()
    {
        gameManagerScript.ShowCredits();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ReturnToMainMenu();
        }        
    }

    public void playButtonSound()
    {
        audio.Play();
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void StartLevel01()
    {
        SceneManager.LoadScene("Level01");
    }

    public void ShowCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ShowHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}

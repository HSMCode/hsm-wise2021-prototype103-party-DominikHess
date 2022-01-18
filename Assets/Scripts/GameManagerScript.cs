using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    private AudioSource audio;
    private MusicScript musicScript;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        musicScript = FindObjectOfType<MusicScript>();
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
        if (!musicScript.GetComponent<AudioSource>().isPlaying)
        {
            musicScript.GetComponent<AudioSource>().Play();
        }
        SceneManager.LoadScene("TitleScreen");
    }

    public void StartLevel01()
    {
        musicScript.GetComponent<AudioSource>().Stop();
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

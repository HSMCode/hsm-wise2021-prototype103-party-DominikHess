using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug Commands

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ReturnToMainMenu();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            StartLevel01();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            GameOver();
        }
        
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
        SceneManager.LoadScene("GameOver"); // To Do
    }

    public void ShowHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}

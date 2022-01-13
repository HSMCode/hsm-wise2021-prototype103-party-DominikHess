using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    private AudioSource audio;
    public Text gameOverCauseText;
    public static bool teaDestroyed;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();

        if (teaDestroyed)
        {
            gameOverCauseText.text = "Bollocks! \n The tea is lost!";
        }
        else
        {
            gameOverCauseText.text = "Bloody hell! \n Don't shoot the civillians!";
        } 
    }

    void Update()
    {
        if (Input.anyKey && Time.timeSinceLevelLoad > 2.5f)
        {
            FindObjectOfType<GameManagerScript>().ReturnToMainMenu();
        }
    }
}

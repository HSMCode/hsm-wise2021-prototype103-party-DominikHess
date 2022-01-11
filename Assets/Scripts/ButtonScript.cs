using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public void playButton()
    {
        FindObjectOfType<GameManagerScript>().StartLevel01();
    }
    public void mainMenuButton()
    {
        FindObjectOfType<GameManagerScript>().ReturnToMainMenu();
    }
}

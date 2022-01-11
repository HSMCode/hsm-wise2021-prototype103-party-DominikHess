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
            Restart();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ReturnToMainMenu();
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Level01");
    }
}

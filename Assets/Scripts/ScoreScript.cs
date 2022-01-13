using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    void Update()
    {
        if (score < 0)
        {
            Invoke("NegativeScore", 1.5f);
        }
    }

    private void NegativeScore()
    {
        GameOverScript.teaDestroyed = false;
        FindObjectOfType<GameManagerScript>().GameOver();
    }

    public void AddScore(int addedValue)
    {
        score += addedValue;
        scoreText.text = "Score: " + score;
    }
}

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

    public void AddScore(int addedValue)
    {
        score += addedValue;
        scoreText.text = "Score: " + score;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private int movementSpeed = 5;
    public SpawnScript spawnScript;
    public ProcessHealthScript processHealthScript;
    public ScoreScript scoreScript;
    public FeedbackMessagesScript feedbackMessagesScript;

    // Start is called before the first frame update
    void Start()
    {
        scoreScript = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreScript>();
        feedbackMessagesScript = GameObject.FindGameObjectWithTag("Player").GetComponent<FeedbackMessagesScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
    }

    public void setMovementSpeed(int value)
    {
        movementSpeed = value;
    }

    void OnCollisionEnter(Collision collision)
    {
        destroyPassenger(collision);
    }

    public void destroyPassenger(Collision collision)
    {
        // If a passenger reaches the left level border: Check if they are a Patriot and calculate score accordingly
        if (collision.gameObject.tag == "LevelBorderLeft")
        {
            if (gameObject.tag == "Patriot")
            {
                feedbackMessagesScript.PatriotOnBoardFeedback();
                processHealthScript = GameObject.FindGameObjectWithTag("Player").GetComponent<ProcessHealthScript>();
                processHealthScript.IncreasePatriotAmount();
            }
            else 
            {
                feedbackMessagesScript.PassengerOnBoardFeedback();
                scoreScript.AddScore(1);
            }
        }

        // Gain 5 Points if you shoot a Patriot
        if (collision.gameObject.tag == "Patriot")
        {
            feedbackMessagesScript.ShotPatriotFeedback();
            scoreScript.AddScore(5);
        }

        // Lose 5 Points if you shoot a Civillian
        if (collision.gameObject.tag == "Passenger")
        {
            feedbackMessagesScript.ShotPassengerFeedback();
            scoreScript.AddScore(-5);
        }

        spawnScript = GameObject.FindGameObjectWithTag("Spawner").GetComponent<SpawnScript>();
        spawnScript.setShouldSpawn();

        Destroy(gameObject);
    }
}

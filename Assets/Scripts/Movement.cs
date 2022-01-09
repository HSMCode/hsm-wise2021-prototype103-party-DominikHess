using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private int moveSpeed = 5;
    public SpawnScript spawnScript;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        destroyPassenger(collision);
    }

    public void destroyPassenger(Collision collision)
    {
        // If a passenger reaches the left level border: Cgeck if they are a Patriot and calculate score accordingly
        if (collision.gameObject.tag == "LevelBorderLeft")
        {
            if (gameObject.tag == "Patriot")
            {
                Debug.Log("Oops! Patriot on Board!");
            }
            else 
            {
                Debug.Log("Civillian on Board!");
            }
        }

        if (collision.gameObject.tag == "Patriot")
        {
            Debug.Log("Shot Patriot");
           
        }

        if (collision.gameObject.tag == "Passenger")
        {
            Debug.Log("Shot Civillian");
        }

        spawnScript = GameObject.FindGameObjectWithTag("Spawner").GetComponent<SpawnScript>();
        spawnScript.setShouldSpawn();

        Destroy(gameObject);
    }
}

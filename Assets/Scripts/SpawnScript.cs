using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] passengers;
    public bool shouldSpawn = false;
    public Movement movementScript;
    private int random;

    void Start()
    {
        StartCoroutine(passengerWave());
    }

    public void spawnPassenger()
    {
        random = Random.Range(0, passengers.Length);   
        GameObject targetClone = Instantiate(passengers[random]) as GameObject;
        targetClone.transform.position = new Vector3(-3.5f, 1, 30);

        random = Random.Range(8, 12);
        movementScript = targetClone.GetComponent<Movement>();
        movementScript.setMovementSpeed(random);

        shouldSpawn = false;   
    }

    IEnumerator passengerWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);

            if (shouldSpawn == true)
            {
                spawnPassenger();
            }
        }
    }

    public void setShouldSpawn()
    {
        shouldSpawn = true;
    }
}

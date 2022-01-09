using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] passengers;
    public bool shouldSpawn = false;
    private int random;

    void Start()
    {
        StartCoroutine(passengerWave());
    }

    public void spawnPassenger()
    {
        random = Random.Range(0, 3);

        GameObject targetClone = Instantiate(passengers[random]) as GameObject;
        targetClone.transform.position = new Vector3(-3.5f, 1, 30);
        shouldSpawn = false;
    }

    IEnumerator passengerWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);

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

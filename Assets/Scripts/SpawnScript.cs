using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject targetPrefab;
    public bool shouldSpawn = false;

    void Start()
    {
        StartCoroutine(passengerWave());
    }

    public void spawnPassenger()
    {
        GameObject targetClone = Instantiate(targetPrefab) as GameObject;
        targetClone.transform.position = new Vector3(-1, 0, 17);
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

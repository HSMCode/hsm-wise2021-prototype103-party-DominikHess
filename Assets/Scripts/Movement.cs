using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private int moveSpeed = 8;
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
        if (collision.gameObject.tag == "LevelBorderLeft")
        {
            spawnScript = GameObject.FindGameObjectWithTag("Spawner").GetComponent<SpawnScript>();
            spawnScript.setShouldSpawn();
            
            Destroy(gameObject);
        }
    }
}

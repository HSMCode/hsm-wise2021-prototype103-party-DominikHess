using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessHealthScript : MonoBehaviour
{
    public int maxHealth = 10000;
    public int currentHealth;
    public int patriotAmount = 0;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);  
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth < 1)
        {
            FindObjectOfType<GameManagerScript>().GameOver();
        } 
    }

    public void IncreasePatriotAmount()
    {
        patriotAmount += 1;
    }
 
    private void FixedUpdate()
    {
        ProcessHealth(patriotAmount);
    }

    private void ProcessHealth(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}

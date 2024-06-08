using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    int currentHealth;
    public int maxHealth;
    public GameObject WaterBlock_50m;
    void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if(currentHealth <= 0)
        { Death(); }
    }
    public void TakeDamage1(int amount)
    {
        currentHealth -= amount;

        
    }

    
    void Death()
    {
        // Death function
        // TEMPORARY: Destroy Object
        Destroy(gameObject);
        Instantiate(WaterBlock_50m);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
   
    
    void OnTriggerEnter(Collider other)
    {
        // Check if the other game object has a specific tag
        if (other.CompareTag("Player"))
        {
            // Destroy this game object
            Destroy(gameObject);
        }
    }
}


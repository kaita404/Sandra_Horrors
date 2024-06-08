using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnCollision : MonoBehaviour
{
    public GameObject WrongObjectToSpawn; // The prefab to spawn on collision
    public GameObject RightObjectToSpawn; // The prefab to spawn on collision
    public Transform[] spawnLocations; // Array of specific spawn locations
    public Transform[] spawnLocations1; // Array of specific spawn locations
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Assuming the character controller has the "Player" tag
        {
            // Spawn objects at specific locations
            foreach (Transform location in spawnLocations)
            {
                Instantiate(objectToSpawn, location.position, location.rotation);
            }
            foreach (Transform location in spawnLocations1)
            {
                
                Instantiate(rightobjectToSpawn, location.position, location.rotation);
            }
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tip")) // Assuming the character controller has the "Player" tag
        {
            // Spawn objects at specific locations
            /*foreach (Transform location in spawnLocations)
            {
                Instantiate(WrongObjectToSpawn, location.position, location.rotation);
            }*/
            
            {

                //Instantiate(RightObjectToSpawn, location.position, location.rotation);
               RightObjectToSpawn.SetActive(true);
            }
        }
    }
}

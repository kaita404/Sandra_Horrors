using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowLifter : MonoBehaviour
{
    // Duration for which the object will be lifted
    public float liftDuration = 2.0f;
    // Height by which the object will be lifted
    public float liftHeight = 0.5f;
    //public GameObject WrongObjectToSpawn; // The prefab to spawn on collision
    public GameObject RightObjectToSpawn; // The prefab to spawn on collision
    public Transform[] spawnLocations; // Array of specific spawn locations
    public Transform[] spawnLocations1;
    public GameObject arrow1;

    
    

    public void LiftObject()
    {
        // Store the original position
        Vector3 originalPosition = transform.position;

        // Lift the GameObject slightly upwards
        arrow1.transform.position += new Vector3(0, liftHeight, 0);
        
        foreach (Transform location in spawnLocations)
        {
            //Instantiate(WrongObjectToSpawn, location.position, location.rotation);
        }
        foreach (Transform location in spawnLocations1)
        {

            //Instantiate(RightObjectToSpawn, location.position, location.rotation);
            RightObjectToSpawn.SetActive(true);

        }

        RightObjectToSpawn.SetActive(true);
        // Wait for the specified duration
        //yield return new WaitForSeconds(liftDuration);

        // transform.position += new Vector3(0, -liftHeight, 0);
    }
}

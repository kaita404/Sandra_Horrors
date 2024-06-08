using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respondToRaycast : MonoBehaviour
{
    void Update()
    {
        // Check for a mouse click
        
            // Create a ray from the camera to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Perform the raycast
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the raycast hit this object
                if (hit.transform == transform)
                {
                    // Respond to the raycast hit
                    RespondToRaycast();
                }
            }
        
    }

    private void RespondToRaycast()
    {
        // Print a message to the console
        Debug.Log("Raycast hit the object: " + gameObject.name);

        // Add additional response behavior here
    }
}


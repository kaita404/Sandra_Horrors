using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShooter : MonoBehaviour
{
    [SerializeField] private float rayLength = 10f; // Length of the raycast
    Animator anim;
    public GameObject RightObjectToSpawn; // The prefab to spawn on collision

    public ArrowLifter arrow1;


     void Start()
    {
        arrow1 = GetComponent<ArrowLifter>();

        
    }
    void Update()
    {
        // Shoot a raycast forward from the player's position
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Input.GetKeyDown("space"))
        {
            if (Physics.Raycast(ray, out hit, rayLength))
            {
                if(hit.transform.gameObject.name == "puzzle")
                {
                    //anim = hit.transform.gameObject.GetComponent<Animator>();
                    // anim.enabled = !anim.enabled;

                    //arrow.SetActive(true);

                    arrow1 = hit.collider.GetComponent<ArrowLifter>();

                    arrow1.LiftObject();
                    


                }
                // If the raycast hits something, log the details
                // Debug.Log(arrow1);


            }
        }

        // Visualize the raycast in the scene view
        Debug.DrawRay(ray.origin, ray.direction * rayLength, Color.red);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushingScript : MonoBehaviour
{
    [SerializeField]

    private float forcemagnitude;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;

        if (rigidbody != null)
        {
            Vector3 forcedirction = hit.gameObject.transform.position - transform.position;
            forcedirction.y = 0;
            forcedirction.Normalize();

            rigidbody.AddForceAtPosition(forcedirction * forcemagnitude, transform.position, ForceMode.Impulse);
        }
    }
}

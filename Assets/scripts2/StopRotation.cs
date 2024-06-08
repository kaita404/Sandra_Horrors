using UnityEngine;

public class StopRotation : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // This will stop the rotation of the player
        rb.angularVelocity = Vector3.zero;
    }
}


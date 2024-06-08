using UnityEngine;

public class FreezeXAxis : MonoBehaviour
{
    private CharacterController controller;
    private float lockedXPosition;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        lockedXPosition = transform.position.x; // Store the initial x position
    }

    void Update()
    {
        Vector3 position = transform.position;
        position.x = lockedXPosition; // Lock the x position
        controller.Move(position - transform.position); // Apply the position change
    }
}

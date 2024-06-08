using UnityEngine;

public class PlayerMovementWithGravity : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpHeight = 3f;
    public float gravity = 9.8f; // Adjust as needed

    private CharacterController controller;
    private Vector3 velocity; // Current velocity

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Get input from the player (arrow keys or WASD)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
        moveDirection.Normalize();

        // Apply gravity
        if (!controller.isGrounded) // If not on the ground
            velocity.y -= gravity * Time.deltaTime;

        // Move the player
        controller.Move((moveDirection * moveSpeed + velocity) * Time.deltaTime);

        // Jump
        if (controller.isGrounded && Input.GetKeyDown(KeyCode.Space))
            velocity.y = Mathf.Sqrt(2f * jumpHeight * gravity);

        // Reset vertical velocity when grounded
        if (controller.isGrounded)
            velocity.y = 0f;
    }
}

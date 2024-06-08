using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator animator;
    private CharacterController characterController;
    public float moveSpeed = 5f; // Adjust this to control movement speed
    public float rotationSpeed = 100f; // Adjust this for rotation speed

    private Transform pivot; // Empty GameObject for rotation pivot

    public Rigidbody rb1;

    [SerializeField] private float rotationSpeed1 = 5f;
    [SerializeField] private float movementSpeed = 5f;
    private void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();

        //rb1 = GetComponent<Rigidbody>();
        // Create an empty GameObject as the pivot
        pivot = new GameObject("Pivot").transform;
        pivot.SetParent(transform); // Set the player as the parent
        pivot.localPosition = Vector3.zero; // Center the pivot      
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

      //  Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // cursorPos.z = transform.position.z;

        if (moveDirection.magnitude > 0.1f)
        {
            // Player is moving
            animator.SetInteger("Speed", 1); // Walk animation

            // Move the player
           // rb1.MovePosition(moveVector);
        }


        else
        {
            // Player is idle
            animator.SetInteger("Speed", 0); // Idle animation
        }

        bool isRunning = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        if (isRunning)
        {
            animator.SetInteger("Speed", 2); // Run animation
        }

        // Rotate the pivot using arrow keys
        Vector3 rotation = Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(rotation);
      

        
        Vector3 moveVector = transform.TransformDirection(moveDirection) * moveSpeed * Time.fixedDeltaTime;

         if (characterController.isGrounded)
         {
             moveVector.y = -0.05f;
         }
         else
         {
             moveVector.y = -4.0f;

         }

        //transform.position = new Vector3(transform.position.x, 2.28f, transform.position.z);
        characterController.Move(moveVector);



    }


}

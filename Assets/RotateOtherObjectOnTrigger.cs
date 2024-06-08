using UnityEngine;

public class RotateOtherObjectOnTrigger : MonoBehaviour
{
    public GameObject objectToRotate; // Reference to the game object you want to rotate
    public float rotationSpeed = 30f; // Adjust the rotation speed as needed
    private bool isInsideCollider = false;
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Replace "Player" with the appropriate tag
        {
            isInsideCollider = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInsideCollider = false;
            
        }
    }

    private void Update()
    {
        if (isInsideCollider)
        {
            // Rotate the other game object around its up axis
            objectToRotate.transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            anim.SetBool("up", true);

        }
        if (!isInsideCollider)
        {
            anim.SetBool("up", false);

        }
    }
}

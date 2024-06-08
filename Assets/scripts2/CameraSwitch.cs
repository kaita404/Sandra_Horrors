using UnityEngine;

public class CameraSwitchTrigger : MonoBehaviour
{
    public Camera firstCamera; // Reference to the first camera
    public Camera secondCamera; // Reference to the second camera

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Switch cameras
            firstCamera.enabled = false;
            secondCamera.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Revert back to the first camera
            firstCamera.enabled = true;
            secondCamera.enabled = false;
        }
    }
}

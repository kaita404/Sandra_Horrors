using UnityEngine;
using UnityEngine.UI;

public class TriggerText : MonoBehaviour
{
    // The text component to display the message
    public Text messageText;

    // The message to display when the trigger is entered
    public string message = "You entered the trigger!";

    // The duration of the message in seconds
    public float messageDuration = 3f;

    // A timer to keep track of how long the message has been shown
    private float timer = 0f;

    // A flag to indicate if the message is currently shown
    private bool showMessage = false;

    // This method is called when another collider enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Set the message text to the message string
        messageText.text = message;

        // Set the show message flag to true
        showMessage = true;

        // Reset the timer to zero
        timer = 0f;
    }

    // This method is called once per frame
    private void Update()
    {
        // If the show message flag is true
        if (showMessage)
        {
            // Increment the timer by the time since the last frame
            timer += Time.deltaTime;

            // If the timer exceeds the message duration
            if (timer > messageDuration)
            {
                // Set the message text to an empty string
                messageText.text = "";

                // Set the show message flag to false
                showMessage = false;
            }
        }
    }
}

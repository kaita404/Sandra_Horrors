using UnityEngine;

public class FadingObjectOnTrigger : MonoBehaviour
{
    public GameObject objectToFade; // Reference to the object you want to fade in
    public float fadeDuration = 2f; // Duration of the fade (in seconds)

    private CanvasGroup canvasGroup;
    private bool isFading = false;

    private void Start()
    {
        // Get or add the CanvasGroup component
        canvasGroup = objectToFade.GetComponent<CanvasGroup>();
        if (canvasGroup == null)
            canvasGroup = objectToFade.AddComponent<CanvasGroup>();

        // Set initial alpha to 0 (fully transparent)
        canvasGroup.alpha = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isFading)
        {
            // Start fading in
            StartCoroutine(FadeIn());
        }
    }

    private System.Collections.IEnumerator FadeIn()
    {
        isFading = true;
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            // Calculate the current alpha value (linear interpolation)
            float alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);
            canvasGroup.alpha = alpha;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the alpha is fully opaque
        canvasGroup.alpha = 3f;
        isFading = false;
    }
}

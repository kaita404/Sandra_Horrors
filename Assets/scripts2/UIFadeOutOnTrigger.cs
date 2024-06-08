using UnityEngine;
public class UIFadeOutOnTrigger : MonoBehaviour
{
    public CanvasGroup uiCanvasGroup; // Reference to the CanvasGroup component
    public float fadeDuration = 2f; // Duration of the fade (in seconds)

    private bool isFading = false;

    private void Start()
    {
        // Set initial alpha to 1 (fully opaque)
        uiCanvasGroup.alpha = 1f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isFading)
        {
            // Start fading out
            StartCoroutine(FadeOut());
        }
    }

    private System.Collections.IEnumerator FadeOut()
    {
        isFading = true;
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            // Calculate the current alpha value (linear interpolation)
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeDuration);
            uiCanvasGroup.alpha = alpha;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the alpha is fully transparent
        uiCanvasGroup.alpha = 0f;
        isFading = false;
    }
}

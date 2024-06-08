using UnityEngine;

public class FadingObjectOnTrigger1 : MonoBehaviour
{
    public GameObject objectToFade1; // Reference to the object you want to fade in
    public float fadeDuration1 = 10f; // Duration of the fade (in seconds)

    private CanvasGroup canvasGroup1;
    private bool isFading1 = false;

    private void Start()
    {
        // Get or add the CanvasGroup component
        canvasGroup1 = objectToFade1.GetComponent<CanvasGroup>();
        if (canvasGroup1 == null)
            canvasGroup1 = objectToFade1.AddComponent<CanvasGroup>();

        // Set initial alpha to 0 (fully transparent)
        canvasGroup1.alpha = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isFading1)
        {
            // Start fading in
            StartCoroutine(FadeIn1());
        }
    }

    private System.Collections.IEnumerator FadeIn1()
    {
        isFading1 = true;
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration1)
        {
            // Calculate the current alpha value (linear interpolation)
            float alpha = Mathf.Lerp(0f, 2f, elapsedTime / fadeDuration1);
            canvasGroup1.alpha = alpha;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the alpha is fully opaque
        canvasGroup1.alpha = 10f;
        isFading1 = false;
    }
}

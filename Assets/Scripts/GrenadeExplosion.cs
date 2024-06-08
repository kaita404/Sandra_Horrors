using UnityEngine;
using System.Collections;


public class GrenadeExplosion : MonoBehaviour
{

    public GameObject explosionPrefab; // Assign your explosion effect prefab in the inspector
    public float explosionForce = 10f; // Adjust the explosion force as needed
    public float explosionRadius = 5f; // Adjust the explosion radius as needed
    public float upwardsModifier = 3f; // Adjust the upwards force modifier as needed


    void OnCollisionEnter(Collision collision)
    {
        // Start the explosion sequence with a delay
        StartCoroutine(ExplosionDelay());
    }

    IEnumerator ExplosionDelay()
    {
        // Wait for 1 second
        yield return new WaitForSeconds(1f);

        // Instantiate the explosion effect at the grenade's position
        Instantiate(explosionPrefab, transform.position, transform.rotation);

        // Apply an explosion force to nearby rigidbodies
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, upwardsModifier);
            }
        }

        // Destroy the grenade object to simulate the explosion
        Destroy(gameObject);
    }
}


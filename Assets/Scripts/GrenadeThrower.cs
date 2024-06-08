using UnityEngine;

public class GrenadeThrower : MonoBehaviour
{
    public Rigidbody grenadePrefab; // Assign your grenade prefab in the inspector
    public float throwForce = 40f; // Adjust the throw force as needed

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) // Press G to throw a grenade
        {
            ThrowGrenade();
        }
    }

    void ThrowGrenade()
    {
        // Create a new grenade instance at the player's position and rotation
        Rigidbody grenadeInstance = Instantiate(grenadePrefab, transform.position, transform.rotation);

        // Apply a force to the grenade to throw it
        grenadeInstance.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }
}


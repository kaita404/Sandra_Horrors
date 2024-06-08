using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycollsion : MonoBehaviour
{
    public GameObject enemy;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
            Destroy(other.gameObject);
        Debug.Log(other);
    }
}

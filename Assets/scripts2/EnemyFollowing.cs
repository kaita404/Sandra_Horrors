using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class EnemyFollowing : MonoBehaviour

{
    public Transform target;
    public int speed;

    public GameObject player;

    void Start()

    {

        transform.Rotate(0, 0, 0);

    }

    void Update()

    {
        transform.LookAt(target);

        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            Destroy(player);
        Debug.Log(other);
    }

}
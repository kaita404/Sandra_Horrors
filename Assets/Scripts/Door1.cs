using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour


{
    public Transform door1; 

    private bool open1 = false;

    public Vector3 opened1Position = new Vector3(3, 10, -7);
    public Vector3 closed1Position = new Vector3(8, 4, -5);

    public float open1_speed = 5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (open1)
        {
            door1.position = Vector3.Lerp(door1.position, opened1Position, Time.deltaTime * open1_speed);
        }
        else
        {
            {
                door1.position = Vector3.Lerp(door1.position, closed1Position, Time.deltaTime * open1_speed);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OpenDoor1();
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            CloseDoor1();
        }
      
    }
    public void OpenDoor1()
    {
        open1 = false;
    }

    public void CloseDoor1()
    {
        open1 = true;
    }
}



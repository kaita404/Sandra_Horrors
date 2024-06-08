using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour


{
    public Transform door2; 

    private bool open1 = false;

    public Vector3 opened2Position = new Vector3(3, 10, -7);
    public Vector3 closed2Position = new Vector3(8, 4, -5);

    public float open2_speed = 5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (open1)
        {
            door2.position = Vector3.Lerp(door2.position, opened2Position, Time.deltaTime * open2_speed);
        }
        else
        {
            {
                door2.position = Vector3.Lerp(door2.position, closed2Position, Time.deltaTime * open2_speed);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OpenDoor2();
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            CloseDoor2();
        }
      
    }
    public void OpenDoor2()
    {
        open1 = false;
    }

    public void CloseDoor2()
    {
        open1 = true;
    }
}



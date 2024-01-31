using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    void Update()
    {
        // Moves the object forward one unit every frame.
        transform.position += new Vector3(0, 0, 1);
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "Player")
        {
            // Add code to reset position of player to spawn
        
            Debug.Log("You died");
        }
        else if (collision.gameObject.name == "WallReset")
        {
            //Add code to reset position of car to start point
        }
    }
}
/*
 * Store the original position in the Start or Awake function:

Vector3 originalPos;

void Start()
 {
     originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
//alternatively, just: originalPos = gameObject.transform.position;

 }
 void OnTriggerEnter(Collider other)
 {
     if(other.gameObject.tag == "End")
     {
         gameObject.transform.position = originalPos;
     }
   
 }
https://discussions.unity.com/t/i-want-to-reset-my-object-to-its-original-position/188315/2
 */
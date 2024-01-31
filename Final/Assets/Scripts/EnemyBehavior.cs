using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Reference to the PlayerBehavior script.
    private PlayerBehavior playerBehavior;

    // This method is called when a Collider enters the trigger zone.
    void OnTriggerEnter(Collider other)
    {
        // Check if the entering Collider has the name "Player".
        if (other.CompareTag("Player"))
        {
            // Get the PlayerBehavior component from the player GameObject.
            playerBehavior = other.GetComponent<PlayerBehavior>();

            // Reset the player's position to the start position.
            playerBehavior.ResetToStartPosition();

            // Prints a message indicating that the player is detected, and the enemy should attack.
            Debug.Log("Player detected - reset to start position!");
        }
    }

    
    
    }

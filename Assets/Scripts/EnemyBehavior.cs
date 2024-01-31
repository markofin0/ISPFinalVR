using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Reference to the PlayerBehavior script.
    private PlayerBehavior playerBehavior;

    // This method is called when a Collider collides with another Collider.
    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the tag "Player".
        if (collision.collider.CompareTag("Player"))
        {
            // Get the PlayerBehavior component from the player GameObject.
            playerBehavior = collision.collider.GetComponent<PlayerBehavior>();

            // Reset the player's position to the start position.
            playerBehavior.ResetToStartPosition();

            // Prints a message indicating that the player is detected, and the enemy should attack.
            Debug.Log("Player detected - reset to start position!");
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    // camOffset is a Vector3 variable that determines the camera's position relative to the target (the player).
    public Vector3 camOffset = new Vector3(0f, 6f, -10f); // Adjusted camOffset for over-the-shoulder view

    // A Transform variable to store a reference to the target (player's transform).
    private Transform target;

    // Start is called before the first frame update.
    void Start()
    {
        // Find the player GameObject and get its transform component.
        target = GameObject.Find("Player").transform;
    }

    // LateUpdate is called once per frame, after all Update methods are called.
    void LateUpdate()
    {
        // Calculate the desired position for the camera
        Vector3 desiredPosition = target.position + target.TransformDirection(camOffset);

        // Set the camera's position
        transform.position = desiredPosition;

        // Make the camera look at the target's position with an offset for over-the-shoulder view
        transform.LookAt(target.position + Vector3.up * 3f);
    }
}

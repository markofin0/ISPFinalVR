using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private const float walkSpeed = 5.0f;
    private const float runSpeed = 10.0f;

    private float moveSpeed = walkSpeed;    // Our current movement speed

    // Rotation speed of the player.
    public float rotateSpeed = 75f;

    // Input variables for vertical and horizontal movement.
    private float vInput;
    private float hInput;

    // Reference to the Rigidbody component attached to the player.
    private Rigidbody _rb;

    private Vector3 startPosition;

    // Start is called before the first frame update.
    void Start()
    {
        startPosition = transform.position;

        // Assign the Rigidbody component of the player to the _rb variable.
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame.
    void Update()
    {
        // Capture input for vertical and horizontal movement.
        vInput = Input.GetAxis("Vertical");
        hInput = Input.GetAxis("Horizontal");

        // Toggle between walk and run speeds based on shift key
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = runSpeed;
        }
        else
        {
            moveSpeed = walkSpeed;
        }

        // Apply movement speed to vertical input.
        vInput *= moveSpeed;
    }

    void FixedUpdate()
    {
        // Calculate the rotation vector based on the horizontal input.
        Vector3 rotation = Vector3.up * hInput;

        // Convert the rotation vector into a Quaternion representing the rotation over time.
        Quaternion angleRot = Quaternion.Euler(rotation * rotateSpeed * Time.fixedDeltaTime);

        // Move the Rigidbody's position forward based on the vertical input.
        _rb.MovePosition(this.transform.position + this.transform.forward * vInput * Time.fixedDeltaTime);

        // Rotate the Rigidbody using the calculated angle rotation.
        _rb.MoveRotation(_rb.rotation * angleRot);
    }

    // Called when the player collides with another object.
    void OnCollisionEnter(Collision collision)
    {
        // If the player collides with something tagged as "Wall"...
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Stop the player's movement.
            _rb.velocity = Vector3.zero;
        }
    }

    // Reset the player to the starting position.
    public void ResetToStartPosition()
    {
        transform.position = startPosition;
    }
}

using UnityEngine;

public class TunnelExit : MonoBehaviour
{
    // Original position of the van
    private Vector3 originalPosition;

    private void Start()
    {
        // Assuming the van's original position is set in the inspector
        // You can also set this programmatically if needed
        originalPosition = GameObject.FindGameObjectWithTag("Van").transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is tagged as "Van"
        if (collision.gameObject.CompareTag("Van"))
        {
            // Reset the van's position to its original position
            collision.gameObject.transform.position = originalPosition;
        }
    }
}
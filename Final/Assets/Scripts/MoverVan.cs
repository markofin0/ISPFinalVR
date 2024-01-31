using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverVan : MonoBehaviour
{

    public float speed = .05f;
    void Update()
    {
        // Moves an object forward, relative to its own rotation.
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanBehavior : MonoBehaviour
{
  private Vector3 startPosition = Vector3.zero;

    private void Start()
    {
        startPosition = transform.position;
    }
}

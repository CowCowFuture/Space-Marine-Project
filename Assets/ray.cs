using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour
{
    void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward)))
        {
            print("balls");
        }
    }
}

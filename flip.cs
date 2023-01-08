using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{

    void Start()
    {

    }

    void FixedUpdate()
    {

        if (Input.GetKey("a"))
        {
            Vector3 newRotation = new Vector3(0, -180, 0);
            transform.eulerAngles = newRotation;
        }
        else if (Input.GetKey("d"))
        {
            Vector3 newRotation = new Vector3(0, 0, 0);
            transform.eulerAngles = newRotation;
        }
    }
}
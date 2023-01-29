using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Object rotation by x axis
    [SerializeField] float xAngle = 0f;
    // Object rotation by y axis
    [SerializeField] float yAngle = 1f;
    // Object rotation by z axis
    [SerializeField] float zAngle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Object rotation
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}

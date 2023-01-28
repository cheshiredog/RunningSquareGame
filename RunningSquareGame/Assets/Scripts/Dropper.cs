using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    // Setting time to wait before falling
    [SerializeField] float fallingTime = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Getting access to mesh renderer
        meshRenderer = GetComponent<MeshRenderer>();
        // Getting access to rigid body
        rigidBody = GetComponent<Rigidbody>();

        // Making obstacle invisible
        meshRenderer.enabled = false;
        // Turning off the gravity
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Waiting some time
        if(Time.time > fallingTime)
        {
            // Making obstacle visible
            meshRenderer.enabled = true;
            // Turning on the gravity
            rigidBody.useGravity = true;
        }
    }
}

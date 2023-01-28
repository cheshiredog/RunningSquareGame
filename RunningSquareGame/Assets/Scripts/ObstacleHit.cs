using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHit : MonoBehaviour
{
    // When something bumped into this object
    public void OnCollisionEnter(Collision collision)
    {
        // Checking out if the collided object is player
        if(collision.gameObject.tag == "Player")
        {
            // Changing the obstacle's color to red
            GetComponent<MeshRenderer>().material.color = Color.red;
            // Changing the obstacle's tag to "Hit" to know that we've already bumped into this obstacle
            gameObject.tag = "Hit";
        }
    }
}

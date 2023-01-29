using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    // Player's score (how many times player bumped into an obstacle)
    int hits = 0;

    // When player bumped into some obstacle
    private void OnCollisionEnter(Collision collision)
    {
        // Checking if the obstacle hasn't been hit before
        if(collision.gameObject.tag != "Hit" & collision.gameObject.tag != "Ramp")
        {
            // Increasing player's score
            hits++;
        }

        // Printing player's score to the console
        Debug.Log($"You've bumped into an obstacle {hits} times.");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHit : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        // Changing obstacle's color to red
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}

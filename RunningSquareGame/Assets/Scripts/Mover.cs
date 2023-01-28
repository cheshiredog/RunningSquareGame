using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Player's speed of movement
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInsructions();
    }

    // Update is called once per frame
    void Update()
    {   
        MovePlayer();
    }

    // Printing message for the player to the console
    void PrintInsructions()
    {
        Debug.Log("Welcome to the game. \n You can move this blue square with W A S D keys. \n Thanks for playing, have fun. :)");
    }

    // Moving player
    void MovePlayer()
    {
        // Movement on x axis
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        // Movement on z axis
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        // Player's moving
        transform.Translate(xValue, 0, zValue);
    }
}

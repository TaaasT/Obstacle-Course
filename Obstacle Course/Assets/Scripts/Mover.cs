using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("welcome to the game!");
        Debug.Log("Use WASD to move your character");
        Debug.Log("Don't hit the walls!!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }

}

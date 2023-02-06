using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    [SerializeField] float moveSpeed = 12f;

    // Start is called before the first frame update
    void Start () 
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update () 
    {
        MovePlayer();
    }

    // Print instructions to the console
    void PrintInstruction () 
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move with WASD or arrow keys and dodge the obstacle as many as many times as possible to increase your score and hop onto the Leaderboards!");
        Debug.Log("Have fun!");
    }

    // Move player
    void MovePlayer () {
        float xValue = Input.GetAxis("Horizontal") * (Time.deltaTime * moveSpeed);
        float zValue = Input.GetAxis("Vertical") * (Time.deltaTime * moveSpeed);

        transform.Translate(xValue, 0, zValue);
    }
}

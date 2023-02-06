using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // If player COLLIDES with an object, turn it´s color to red and assign the object tag to "Hit"
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player") {
            GetComponent<MeshRenderer>().material.color = Color.red;

            gameObject.tag = "Hit";
        }
    }
}

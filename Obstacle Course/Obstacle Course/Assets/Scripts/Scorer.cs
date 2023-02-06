using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
   
   // On Collision, if target hasn´t been hit before, hits increases 1
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit") {
            hits++;
            Debug.Log("You´ve bumped into a thing this many times: " + hits);
        }
    }
}

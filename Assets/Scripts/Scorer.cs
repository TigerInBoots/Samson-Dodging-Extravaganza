using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    int collisionCounter = -1;

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Hit")
        {
            //adds 1 collision
            collisionCounter++;

            if (collisionCounter > 0)
            {
                if (collisionCounter == 1)
                {
                    Debug.Log("You've bumped into a thing " + collisionCounter + " time.");
                }

                else
                {
                    Debug.Log("You've bumped into a thing " + collisionCounter + " times.");
                }
            }
        }
    
    }
}

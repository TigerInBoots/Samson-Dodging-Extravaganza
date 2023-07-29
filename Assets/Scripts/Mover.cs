using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    // [SerializeField] for the in-Unity field
    float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

   void PrintInstructions()
   {
        Debug.Log("Welcome to the game");
        Debug.Log("Use WASD to move around");
        Debug.Log("Good luck and have fun!");
   }

   void MovePlayer()
   {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;

        transform.Translate(xValue,0,zValue);
   }



}

// Method/function
    // void = return nothing
    // () is parameter. Empty means nothing required.
    
    //Example:
    //bool CleanYourRoom(int time)
    //{
        //Do it before time;
        //Pick up clothes;
        //Throw out garbage;
        //Did you find lost homework (aka instead of void) (True/false so bool);
    //}

    // To call the method you could say.
    // CleanYourRoom(time);
    // https://www.gamedev.tv/courses/1111834/lectures/24009616

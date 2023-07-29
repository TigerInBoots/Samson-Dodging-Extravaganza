using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    float xSpin = 0f;
    float ySpin = 0.5f;
    float zSpin = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xSpin, ySpin, zSpin);
    }
}

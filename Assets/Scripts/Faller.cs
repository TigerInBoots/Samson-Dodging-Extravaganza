using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faller : MonoBehaviour
{

    MeshRenderer renderer;
    Rigidbody rigidBody;
    [SerializeField] float fallStartTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > fallStartTime)
       {
            renderer.enabled = true;
            rigidBody.useGravity = true;
       }
        

    }
}

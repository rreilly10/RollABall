using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed; // public vars available in the unity editor 

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Called before rendering a frame (most game code)
    void Update () {
		
	}

    // Physics code -- updates 
    private void FixedUpdate()
    {
        // Input class - use class to read the axes set up in the Input Manager,
        // and to access multi-touch/accelerometer data on mobile devices.
        // https://docs.unity3d.com/ScriptReference/Input.html 

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Vector3 -- 3D Movement
        // x --> L or R
        // y --> 0 (no up or down)
        // z --> Vertical
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        // Rigidbody -  Control of an object's position through physics simulation.
        // https://docs.unity3d.com/ScriptReference/Rigidbody.html
        rb.AddForce(movement * speed);

    }
}

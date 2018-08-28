using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
    Rigidbody rb;
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.W))
            rb.AddTorque(Vector3.up * 200);

        if (Input.GetKey(KeyCode.Q))
            rb.AddForce(Vector3.left * 500);

        if (Input.GetKey(KeyCode.S))
            rb.velocity = new Vector3(1, 0, 0);

        

    }
}

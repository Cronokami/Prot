using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody rb;
    public float moveSpeed, rotationSpeed;
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.W))
            rb.MovePosition(transform.position +
                transform.TransformDirection(Vector3.forward *
                moveSpeed) * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            rb.MovePosition(transform.position +
                transform.TransformDirection(Vector3.back *
                moveSpeed) * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            rb.MoveRotation(transform.rotation * 
                Quaternion.Euler(Vector3.up * rotationSpeed * Time.deltaTime));
        
       if (Input.GetKey(KeyCode.D))
            rb.MoveRotation(transform.rotation *
                Quaternion.Euler(Vector3.down * rotationSpeed * Time.deltaTime));

    }
}

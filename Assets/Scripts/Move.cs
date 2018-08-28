using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    CharacterController controller;
    Vector3 moveDirection;
    public GameObject shootPos;
    public GameObject projectile;

    public float speed = 4;
    public float mouseSensitivity = 200;
    public float jumpForce = 7;
    public float gravity = .2f;
    public float rotationLimitMin = -40;
    public float rotationLimitMax = 40;

    float rotationX;

    public GameObject cam;


    void Start()
    {
        
        controller = GetComponent<CharacterController>();
    }

    

    void Update()
    {
        Rotation();


        if (Input.GetButtonDown("Fire1"))
        {
            GameObject _projectile = Instantiate(projectile, shootPos.transform.position, Quaternion.identity);
            Rigidbody _projectileRB = _projectile.GetComponent<Rigidbody>();
            Vector3 _projectileDir = cam.transform.TransformDirection(Vector3.forward * 1000);
            _projectileRB.AddForce(_projectileDir);
            Destroy(_projectile, 1);

        }





        if (controller.isGrounded)
        {
            moveDirection = Vector3.zero;

            if (Input.GetKey(KeyCode.W)) moveDirection.z = speed;
            if (Input.GetKey(KeyCode.S)) moveDirection.z = -speed;
            if (Input.GetKey(KeyCode.D)) moveDirection.x = speed;
            if (Input.GetKey(KeyCode.A)) moveDirection.x = -speed;

            moveDirection = transform.TransformDirection(moveDirection);

            if (Input.GetKeyDown(KeyCode.Space)) moveDirection.y = jumpForce;

        }
        moveDirection.y -= gravity;
        controller.Move(moveDirection * Time.deltaTime);
 
    }

    void Rotation()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime);


        rotationX += Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        rotationX = Mathf.Clamp(rotationX, rotationLimitMin, rotationLimitMax);

        cam.transform.localEulerAngles = new Vector3(-rotationX, cam.transform.localRotation.y, cam.transform.localRotation.z);
    }

    

}
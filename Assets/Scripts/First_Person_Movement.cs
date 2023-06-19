using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_Person_Movement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;
    public float sprint = 24f;
    public float walk = 12f;
    public float gravity = -9.81f;
    public float height = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        
        if(isGrounded && velocity.y <0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Movement
        Vector3 move = transform.right * x + transform.forward * z;

        //Sprint
        if(isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                speed = sprint;
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                speed = walk;                
            }
        }
        //The mid air sprint velocity occoures without pressing the sprint button
        // if(isGrounded)
        // {
        controller.Move(move * speed * Time.deltaTime);
        // }
        // else
        // {
        //     controller.Move(move * sprint * Time.deltaTime);
        // }
        
    
        //Jump
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(height * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        //print(speed);
    }
}

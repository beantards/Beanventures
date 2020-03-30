using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;

    private float moveSpeed = 5.0f;
    private float verticalVelocity;
    private float gravity = 0.4f;
    private float jumpForce = 0.2f;



    // Start is called before the first frame update
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        Vector3 moveVector = Vector3.zero;

        float walkX = Input.GetAxis("Horizontal");
        float walkZ = Input.GetAxis("Vertical");

        moveVector += transform.right * walkX * moveSpeed * Time.deltaTime;
        moveVector.y = verticalVelocity;
        moveVector += transform.forward * walkZ * moveSpeed * Time.deltaTime;
        controller.Move(moveVector);
    }
}

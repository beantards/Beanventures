using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 20f;


    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;
        controller.Move(move * speed * Time.deltaTime);

        /*if (controller.isGrounded && Input.GetButtonDown("Space"))
        {
            moveDirection.y = jumpSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
        */
    }
}
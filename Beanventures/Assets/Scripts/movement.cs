using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20f;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;
        controller.Move(move * speed * Time.deltaTime);


       if (Input.GetButton("Jump"))
       {
          moveDirection.y = jumpSpeed;
       }

    }
}
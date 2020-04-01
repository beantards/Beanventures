using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    private CharacterController controller;

    private float moveSpeed = 5.0f;
    private float verticalVelocity;
    private float gravity = 0.4f;
    private float jumpForce = 0.1f;



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

    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if(other.CompareTag("Beans"))
        {
            //add beans
            Destroy(other.gameObject);
        }
    }
}


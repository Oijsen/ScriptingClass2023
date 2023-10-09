using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float turnSpeed = 50f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f; // Gravity value

    private CharacterController _controller;
    private Vector3 _moveDirection;
    private bool _isJumping = false;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
        
    }

    void Update()
    {

        
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        

        Vector3 forwardMovement = transform.forward * verticalInput * moveSpeed * Time.deltaTime;
        Vector3 turnMovement = transform.up * horizontalInput * turnSpeed * Time.deltaTime;

        if (_controller.isGrounded)
        {
            // Reset jump state when grounded
            _isJumping = false;
            

            if (Input.GetButtonDown("Jump"))
            {
                // Apply jump force
                _moveDirection.y = jumpForce;
                _isJumping = true; // Set to true when jumping
                
            }
        }
        else
        {
            // Apply gravity when not grounded
            _moveDirection.y -= gravity * Time.deltaTime; // Use the serialized gravity value
        }

        // Apply movement
        _controller.Move(forwardMovement);
        transform.Rotate(turnMovement);

        

        // Apply the accumulated movement
        _controller.Move(_moveDirection * Time.deltaTime);
        
    }
}










using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float turnSpeed = 50f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f; // Gravity value

    public float sensitivity = 2f;

    public float sprintSpeed = 10f;
    public float sprintStamina = 100f;
    public float sprintDepletionRate = 20f;
    private bool isSprinting = false;


     public float crouchHeight = 0.5f;
    //public float crouchSpeed = 5f;
    public KeyCode crouchKey = KeyCode.LeftShift;
    private bool isCrouching = false;
    private CharacterController _controller;
    private Vector3 _moveDirection;
    private bool _isJumping = false;

    private bool _isOnGround;

 

    void Start()
    {
        _controller = GetComponent<CharacterController>();
        
    }


    void Update()
    {


        if (Input.GetButtonDown("Jump")){
        
            // Apply jump force
            _moveDirection.y = jumpForce;
            Debug.Log ("Jump Attempt");

            _isJumping = true; // Set to true when jumping
            _isOnGround = false;
        }
        else
        {
            // Apply gravity when not grounded
            _moveDirection.y -= gravity * Time.deltaTime; // Use the serialized gravity value
        }

    
    
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

       


        Vector3 forwardMovement = transform.forward * verticalInput * moveSpeed * Time.deltaTime;
        Vector3 turnMovement = transform.up * horizontalInput * turnSpeed * Time.deltaTime;

        
        if (Input.GetKeyDown(KeyCode.LeftControl) && CanSprint())
        {
            StartSprint();
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl) || !CanSprint())
        {
            StopSprint();
        }

        if (isSprinting)
        {
            // Apply sprint speed
            Vector3 sprintVelocity = transform.forward * sprintSpeed * Time.deltaTime;
            _controller.Move(sprintVelocity);
            // Decrease stamina over time
            sprintStamina -= sprintDepletionRate * Time.deltaTime;
        }
    
        void OnCollisionEnter(Collision other)
        {   //Checks if the player is on the ground
            if(other.gameObject.CompareTag("Enemy"))
            {
                _isOnGround = true;
                Debug.Log("Attack");
            }
        }


        bool CanSprint()
        {
            return !isCrouching && sprintStamina > 0;
        }

        void StartSprint()
        {
            isSprinting = true;
        }

        void StopSprint()
        {
            isSprinting = false;
        }

            if (Input.GetKeyDown(crouchKey))
            {
                ToggleCrouch();
            }
        

        void ToggleCrouch()
        {
            if (isCrouching)
            {
                // Restore normal height and speed
                transform.localScale = new Vector3(1, 1, 1);
                isCrouching = false;
            }
            else
            {
                // Reduce height and speed while crouching
                transform.localScale = new Vector3(1, crouchHeight, 1);
                isCrouching = true;
            }

            
        }
        

        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * mouseX * sensitivity);

        // Apply movement
        _controller.Move(forwardMovement);
        transform.Rotate(turnMovement);

        

        // Apply the accumulated movement
        _controller.Move(_moveDirection * Time.deltaTime);
        
    }

}










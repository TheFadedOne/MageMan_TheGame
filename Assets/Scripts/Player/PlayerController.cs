using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public CharacterController2D controller;
    public float movementSpeed = 40f;
    public float horizontalMovement = 0f;
    public Animator animator;
    public Rigidbody2D rb;
    private bool jump = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        
        animator.SetBool("isJumping", false);
    }

    async void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal") * movementSpeed;

        animator.SetFloat("movementVelocity", Mathf.Abs(rb.velocity.x));


        if (Input.GetButtonDown("Jump") && animator.GetBool("isJumping") == false)
        {
            animator.SetBool("isJumping", true);
            jump = true;
        }
    }

    public void OnLanding()
    {
        jump = false;
        animator.SetBool("isJumping", false);
    }
    private void FixedUpdate()
    {

        controller.Move(horizontalMovement * Time.fixedDeltaTime, false, jump);
        
        
    }
}

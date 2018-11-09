﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float jumpSpeed = 12f;

    public GroundChecker groundCheck;

    private Rigidbody2D rbody;


    
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
 
    void Update()
    {
        rbody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal") * moveSpeed, 
            rbody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            if (groundCheck.isGrounded == true)
            {
                rbody.velocity = new Vector2(
                    rbody.velocity.x,
                    jumpSpeed);
            }
        }
    }
}

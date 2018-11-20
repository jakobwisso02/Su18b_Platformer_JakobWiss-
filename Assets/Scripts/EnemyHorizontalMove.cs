using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMove : MonoBehaviour
{
    public float speed = 5f;
    public bool left = true;

    public GroundChecker check;

    private Rigidbody2D rbody;


    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        left = !left;
    }


    void FixedUpdate()
    {
        if (left == true)
        {       //casting
            rbody.MovePosition(rbody.position + (-(Vector2)transform.right * Time.deltaTime) * speed);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.MovePosition(rbody.position + ((Vector2)transform.right * Time.deltaTime) * speed);
            transform.localScale = new Vector3(-1, 1, 1);
        }


        if (check.isGrounded == false)
        {
            left = !left;
        }
    }
}

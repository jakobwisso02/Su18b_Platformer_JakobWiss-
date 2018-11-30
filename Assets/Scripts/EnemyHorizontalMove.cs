using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMove : MonoBehaviour
{
    public float speed = 5f;
    public bool left = true;

    // Skapar en RigidBody variabel
    private Rigidbody2D rbody;

    void Start()
    {
        // Hämtar en Rigidbody till enemy
        rbody = GetComponent<Rigidbody2D>();
    }


    // Function is called every fixed framerate frame
    private void FixedUpdate()
    {
        // Kollar om boolen left är true
        if (left == true)
        {
            // Sätter hastigheten på enemy till vänster
            // "(Vector2)" betyder att man konverterar från Vector3
            rbody.velocity = -(Vector2)transform.right * speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        // Om boolen "left" är false så gör den detta
        else
        {
            // Sätter hastigheten på enemy till höger
            // "(Vector2)" betyder att man konverterar från Vector3
            rbody.velocity = (Vector2)transform.right * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    // Sent when another object enters a trigger collider attached to this object (2D only)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kollar om det händer en kollision med en tag som heter "InvisibleWall"
        if(collision.tag == "InvisibleWall")
        {
            // Om enemy går in i InvisibleWall så ändrar den riktning
            left = !left;
        }
    }
}

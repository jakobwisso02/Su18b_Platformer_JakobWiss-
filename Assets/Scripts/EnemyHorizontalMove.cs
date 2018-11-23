using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMove : MonoBehaviour
{
    public float speed = 5f;
    public bool left = true;

    private Rigidbody2D rbody;


    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (left == true)
        {       //casting
            rbody.velocity = -(Vector2)transform.right * speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = (Vector2)transform.right * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "InvisibleWall")
        {
            left = !left;
        }
    }
}

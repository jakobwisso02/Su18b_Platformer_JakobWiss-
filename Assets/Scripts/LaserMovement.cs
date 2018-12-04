﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rbody;
    public int damage = 5;


    // Use this for initialization
    void Start()
    {
        //GetComponent<PlayerMovement>;

        //
        rbody.velocity = transform.right * speed;
    }

    // Sent when another object enters a trigger collider attached to this object (2D only)
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Om collisionen händer med en collider som är taggad som Enemy händer det i måsvingarna
        if (collision.tag == "Enemy")
        {
            EnemyHealth enemy = collision.GetComponent<EnemyHealth>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            Destroy(gameObject);
        }

    }

}

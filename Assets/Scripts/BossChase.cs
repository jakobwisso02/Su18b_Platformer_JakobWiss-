using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossChase : MonoBehaviour
{
    // I detta scriptet vill jag få bossen att bara gå åt ett håll så att man måste springa ifrån den och skjuta för att klara spelet


    public float bossSpeed = 3f;

    // Skapar en RigidBody variabel
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        // Hämtar en Rigidbody till enemy från början av spelet
        rbody = GetComponent<Rigidbody2D>();
        
        // Byter storlek på karaktären och switchar x axeln så att bossen kollar åt vänster
        transform.localScale = new Vector3(-5, 5, 5);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Sätter hastigheten på bossen att den ska gå åt sitt "höger" multiplicerat med bossSpeed
        // "Vector2" är när man bara har x och y axlarna
        rbody.velocity = -(Vector2)transform.right * bossSpeed;               
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJump : MonoBehaviour
{
    public float jumpForce = 20f;

    private Rigidbody2D rbody;

    public GroundChecker groundCheck;

    // Hämtar rigidbody2d ifrån start
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        
        // Kallar på funktionen enemyJump
        enemyJump();
    }


    void enemyJump()
    {

        // Om Groundcheckern nuddar marken så är det mer än 0 och den hoppar, om det inte är mer än 0 så kan slimen inte hoppa
        if (EnemyGroundcheck.enemyIsGrounded > 0)
        {
            // Gör så att slimen hoppar med variabeln jumpForce hastighet            
            rbody.velocity = new Vector2(rbody.velocity.x, jumpForce);
        }
    }
}

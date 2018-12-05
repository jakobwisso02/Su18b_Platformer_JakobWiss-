using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJump : MonoBehaviour
{
    public float jumpForce = 8f;

    private Rigidbody2D rbody;

    public GroundChecker groundCheck;

    // TODO: få slimekuben att hoppa med hjälp av rigid bodyn
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        // Om Groundcheckern nuddar marken så är det mer än 0 om det inte är mer så kan slimen inte hoppa
        if (GroundChecker.isGrounded > 0)
        {
            // Gör så att slimen hoppar med variabeln jumpForce hastighet
            rbody.velocity = new Vector2(rbody.velocity.x, jumpForce);
        }

    }

}

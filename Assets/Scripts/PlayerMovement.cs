using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // En static gör att variabeln kan visas globalt i alla scripts. Jag gör dom här om till static för att använda i ett annant script
    public static int moveSpeed = 6;
    public static int jumpSpeed = 12;

    public GameObject laserHand;

    // Gör scriptet "GroundChecker" lätt att länka i detta scriptet med hjälp av variabel
    public GroundChecker groundCheck;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector3(0.75f, 0.75f, 1f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector3(-0.75f, 0.75f, 1f);
            
        }
        
        // Gör så att när man trycker på "Jump" så händer det under
        if (Input.GetButtonDown("Jump"))
        {
            // Om Groundcheckern nuddar marken så är det mer än 0 om det inte är mer så kan man inte hoppa
            if (groundCheck.isGrounded > 0)
            {
                // Gör så att gubben hoppar med variabeln jumpSpeeds hastighet
                rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Static menas att man kan använda variabeln i andra scripts. Som jag gör med dom för att få in dom i powerup scriptet
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
        // x axeln ändrar fart beroende på vilken knapp man trycker på. När man trycker A så blir det -1 * moveSpeed medans y axeln är den nuvarnade man har, den ändras inte.
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);

        // Om man trycker D händer det i måsvingarna
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Player kollar åt höger
            transform.localScale = new Vector3(0.75f, 0.75f, 1f);
        }

        // Om man trycker A händer det i måsvingarna
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Player kollar åt vänster
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



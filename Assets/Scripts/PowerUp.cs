using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D collision)
    {
        // Om collisionen är med ett objekt som är taggat som Player händer det i måsvingarna
        if (collision.tag == "Player")
        {
            // Kallar på Pickup funktionen
            Pickup();
        }
    }

    void Pickup()
    {
        // Hämtar variablerna moveSpeed och jumpSpeed och ändrar deras värde
        PlayerMovement.moveSpeed = 8;
        PlayerMovement.jumpSpeed = 20;

        // Förstör det som scriptet ligger på, i detta fallet power up stjärnan
        Destroy(gameObject);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // En static gör att variabeln kan visas globalt i alla scripts. Bra att ha så att man bara behöver ändra på ett ställe i alla scripts
    public static int score;

    public int amount = 1;

    private float spinSpeed = 180;

    private void Update()
    {
        // Roterar coin spriten varje frame
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }

    // Sent when another object enters a trigger collider attached to this object (2D only)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // Förstör coin spriten
            Destroy(gameObject);

            // Lägger till amount på score
            Coin.score += amount;
        }        
    }




}

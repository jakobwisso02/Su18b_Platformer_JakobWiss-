using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadLevel : MonoBehaviour
{
    // Gör "Su18b_Platformer_JakobWisso" till standardvärdet på vilken scen som ska laddas
    public string sceneToLoad = "Su18b_Platformer_JakobWisso";

    // Sent when another object enters a trigger collider attached to this object (2D only)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kollar om det händer en kollison med taggen "Player"
        if (collision.tag == "Player")
        {
            // Laddar in standard scenen som nu är "Su18b_Platformer_JakobWisso"
            SceneManager.LoadScene(sceneToLoad);

            // Gör så att när scenen laddas om så börjar score på 0
            Coin.score = 0;

            // Gör så att powerup återställs när man dör
            PlayerMovement.moveSpeed = 6;
            PlayerMovement.jumpSpeed = 12;

            
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossReloadLevel : MonoBehaviour {

    // Gör "Level2" till standardvärdet på vilken scen som ska laddas om man använder variabeln
    public string sceneToLoad = "Level2";


    // Sent when another object enters a trigger collider attached to this object (2D only)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Händer bara om det är en kollison med ett objekt med taggen "Player"
        if (collision.tag == "Player")
        {
            // Laddar in standard scenen som nu är "Level2"
            SceneManager.LoadScene(sceneToLoad);
        }
    }


}

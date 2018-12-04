using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{

    public int health = 100;


    public string victorySceneToLoad = "VictoryScreen";


    // Funktionen gör så att bossen tappar HP när den tar damage
    public void TakeDamage(int damage)
    {

        health -= damage;

        // Om health är mindre än 0 så händer det i måsvingarna
        if (health <= 0)
        {
            // Kallar på funktionen void Die
            Die();
        }
    }

    // Denna funktionen tar bort Enemyn från scenen. När jag skjuter och den får mindre än 0 health så försvinner den.
    void Die()
    {
        // Förstör objektet
        Destroy(gameObject);

        // Laddar in VictoryScreen när bossen dör
        SceneManager.LoadScene(victorySceneToLoad);
    }
}

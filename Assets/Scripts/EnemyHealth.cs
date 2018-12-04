using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int health = 10;


    public void TakeDamage(int damage)
    {
        // 
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
        Destroy(gameObject);
    }
}

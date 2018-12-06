using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGroundcheck : MonoBehaviour {

    // Kan använda i flera scripts
    public static int enemyIsGrounded;

    // Sent when another object enters a trigger collider attached to this object (2D only)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Ökar värdet med 1
        enemyIsGrounded++;
    }

    // Sent when another object leaves a trigger collider attached to this object (2D only)
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Minskar värdet med 1
        enemyIsGrounded--;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    // Kan använda i flera scripts
    public static int isGrounded;

    // Sent when another object enters a trigger collider attached to this object (2D only)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Ger boolen ett true värde när groundChecker collidern nuddar ground
        isGrounded++;
    }

    // Sent when another object leaves a trigger collider attached to this object (2D only)
    private void OnTriggerExit2D(Collider2D collision)
    {     
        // Ger boolen ett false värde när groundChecker collidern inte nuddar ground
        isGrounded--;
    }
}

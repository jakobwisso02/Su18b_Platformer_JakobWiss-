﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    // Kan använda i flera scripts
    public static int isGrounded;

    // Sent when another object enters a trigger collider attached to this object (2D only)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Sätter värdet till 1
        isGrounded = 1;
    }

    // Sent when another object leaves a trigger collider attached to this object (2D only)
    private void OnTriggerExit2D(Collider2D collision)
    {     
        // Sätter värdet till 0
        isGrounded = 0;
    }
}

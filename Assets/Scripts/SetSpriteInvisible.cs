using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // Gör spriten osynlig precis när spelet startas
        GetComponent<SpriteRenderer>().enabled = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Enables TextMeshPro
using TMPro;

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI text;

    // Use this for initialization
    void Start()
    {
        // Hämtar textmesh komponent
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // Visar score på hud:en, lägger till score när man collidar med ett coin, (Coin.score) länkar till coinscriptet
        text.text = string.Format("Score: {0:000}", Coin.score);
    }
}

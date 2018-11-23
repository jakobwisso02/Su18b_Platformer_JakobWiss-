using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : MonoBehaviour
{
    public int amount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    private float spinSpeed = 180;
    private void Update()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }

}

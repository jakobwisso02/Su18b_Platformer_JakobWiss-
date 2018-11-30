using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rbody;

  

	// Use this for initialization
	void Start () {
        rbody.velocity = transform.right * speed;
	}

    private void OnTriggerEnter2D()
    {
       
    }

}

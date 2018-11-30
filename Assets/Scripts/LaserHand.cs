using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserHand : MonoBehaviour {


    public Transform firePoint;
    public GameObject laserPrefab;

	// Update is called once per frame
	void Update ()
    {
        // Gör att när man trycker på Fire1 (som på detta spelet är Mouse1) executar den Shoot funktionen som skjuter laser
		if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        // Spawnar lasern vid "firePoint"
        Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
    }
}

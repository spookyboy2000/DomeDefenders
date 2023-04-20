using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{

	public Transform firePoint;
	public GameObject bulletPrefab;
	public int firerate = 2;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetButtonDown("turretshoot"))
		{
			Shoot();
		}
	}

	void Shoot()
	{
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}
}

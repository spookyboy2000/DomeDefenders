using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShoot : MonoBehaviour
{
	public Transform firePoint;
	public GameObject bulletPrefab2;
	private float nextActionTime = 1.0f;
	public float period = 1.0f;
	public float fireRate = 1.0f;
	private float timer = 0.0f;


    private void Start()
    {
		timer = fireRate;
    }
    // Update is called once per frame
    void Update()
	{
		/*
		if (Time.time > nextActionTime)
		{
			nextActionTime += period;
			Shoot();
		}
		*/
		timer += Time.deltaTime;
		if(timer > fireRate)
        {
			Shoot();
			timer = 0.0f;
        }
	}

	void Shoot()
	{
		Instantiate(bulletPrefab2, firePoint.position, firePoint.rotation);
	}
}

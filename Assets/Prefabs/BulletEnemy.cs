using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{

	public float speed = 20f;
	public int damage = 20;
	public Rigidbody2D rb;
	public GameObject impactEffect;

	// Use this for initialization
	void Start()
	{
		rb.velocity = transform.up * speed;
	}

	void OnTriggerEnter2D(Collider2D hitInfo)
	{
		DomeHealth dome = hitInfo.GetComponent<DomeHealth>();
		if (hitInfo.gameObject.tag == "Dome")
		{
			dome.TakeDamage(damage);
			Instantiate(impactEffect, transform.position, transform.rotation);
			Destroy(gameObject);
		}

		//Enemy enemy = hitInfo.GetComponent<Enemy>();
		//if (enemy != null)
		//{
		//	enemy.TakeDamage(damage);
		//}

		//Instantiate(impactEffect, transform.position, transform.rotation);

		
	}

	void Update()
	{
		Destroy(gameObject, 3f);
	}

}

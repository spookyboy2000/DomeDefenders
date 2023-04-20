using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletss : MonoBehaviour
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
		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if (hitInfo.gameObject.tag == "Enemy")
		{
			enemy.TakeDamage(damage);
			Instantiate(impactEffect, transform.position, transform.rotation);
			Destroy(gameObject);
		}

		//Enemy enemy = hitInfo.GetComponent<Enemy>();
		//if (enemy != null)
		//{
		//	enemy.TakeDamage(damage);
		//}

		Instantiate(impactEffect, transform.position, transform.rotation);

		Destroy(gameObject);
	}

    void Update()
    {
		Destroy(gameObject, 3f);
	}


}

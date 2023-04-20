using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

	public int damage = 20;
	public Rigidbody2D rb;
	public GameObject impactEffect;

	// Use this for initialization
	void Start()
	{
		
	}

	void OnTriggerEnter2D(Collider2D hitInfo)
	{
		DomeHealth dome = hitInfo.GetComponent<DomeHealth>();
		if (dome != null)
		{
			dome.TakeDamage(damage);
		}

		Instantiate(impactEffect, transform.position, transform.rotation);

	}

}

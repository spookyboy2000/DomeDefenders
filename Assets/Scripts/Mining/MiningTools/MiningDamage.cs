using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningDamage : MonoBehaviour
{
	public int damage1 = 20;
	public Rigidbody2D rb;
	public GameObject impactEffect;
	public Animator anim;


	// Use this for initialization
	void Start()
	{
        anim.Play("Drill", 0, 0.0f);
    }

	void OnTriggerStay2D(Collider2D hitInfo)
	{
		OreHP ore = hitInfo.GetComponent<OreHP>();
		if (ore != null)
		{
			if (Input.GetKey(KeyCode.Mouse0))
            {
				ore.TakeDamage(damage1);
                anim.SetFloat("reversee", 3);
				new WaitForSeconds(5000);
			}
			//else if (Input.GetKeyUp(KeyCode.Mouse0))
			//{
   //             anim.SetFloat("reversee", 0);
   //         }
			
		}

		//Instantiate(impactEffect, transform.position, transform.rotation);

	}

}

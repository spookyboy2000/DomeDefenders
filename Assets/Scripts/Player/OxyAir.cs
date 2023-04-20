using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxyAir : MonoBehaviour
{
	public int damagee = 20;
	private float nextActionTime = 0.0f;
	public float period = 1.0f;

	// Use this for initialization
	void Start()
	{

	}

	void OnTriggerExit2D(Collider2D hitInfo)
	{
		Oxygenn Oxygen = hitInfo.GetComponent<Oxygenn>();
		if (hitInfo.gameObject.tag == "Dome")
        {
			if (Time.time > nextActionTime)
			{
				nextActionTime += period;
				Oxygen.TakeDamagee(damagee);
			}
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxygenn : MonoBehaviour
{
    private Oxygen2 Oxygen1;
    public int oxygen = 100;

	void Start()
	{
        Oxygen1.SetMaxOxygen(oxygen);
    }

	public void TakeDamagee(int damagee)
	{
		oxygen -= damagee;
        Oxygen1.SetOxygen(oxygen);
        if (oxygen <= 0)
		{
			death();
		}
	}



    void death()
	{
		Destroy(gameObject);
	}
}

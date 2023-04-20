using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreHP : MonoBehaviour
{
	public Transform ore;
	public GameObject ingot;
	public int health = 100;

	void Start()
	{

	}

	public void TakeDamage(int damage1)
	{
		health -= damage1;
		if (health <= 80)
		{
			stage4();
		}
		if (health <= 60)
        {
			stage3();
        }
		if (health <= 40)
        {
			stage2();
        }
		if (health <= 20)
        {
			stage1();
        }
		if (health <= 0)
        {
			stage0();
        }
	}

	void stage4()
	{

	}

	void stage3()
    {

    }

	void stage2()
    {

    }

	void stage1()
    {

    }

	void stage0()
    {
		Instantiate(ingot, ore.position, ore.rotation);
		Destroy(gameObject);
	}

}

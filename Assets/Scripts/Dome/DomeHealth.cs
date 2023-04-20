using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DomeHealth : MonoBehaviour
{
	//private HealthBar healthBar;
	public int health = 100;
	public Animator DomeAnim;

	public GameObject DeathScreen;

	void Start()
	{
		//healthBar.SetMaxHealth(health);
	}

	public void TakeDamage(int damage)
	{
		health -= damage;
		//healthBar.SetHealth(health);
		if (health <= 800)
		{
			stage4();
		}
		if (health <= 750)
        {
			stage3();
        }
		if (health <= 500)
        {
			stage2();
        }
		if (health <= 250)
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
		DomeAnim.SetBool("stage3", true);
    }

	void stage2()
    {
		DomeAnim.SetBool("stage2", true);
	}

	void stage1()
    {
		DomeAnim.SetBool("stage1", true);
	}

	void stage0()
    {
		DeathScreen.SetActive(true);
		Time.timeScale = 0f;
	}

}

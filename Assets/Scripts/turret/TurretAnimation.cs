using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAnimation : MonoBehaviour
{
    public GameObject player;

    public Animator anim;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        anim = gameObject.GetComponent<Animator>();
        anim.Play("turret2", 0, 0.5f);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            anim.SetFloat("reverse", 1.2f);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            //anim.Play("New State");
            anim.SetFloat("reverse", 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            
            anim.SetFloat("reverse", -1.2f);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            //anim.Play("New State");
            anim.SetFloat("reverse", 0);
        }

        //if (Input.GetKey(KeyCode.E))
        //{
        //    Debug.Log("EEEEEE");
        //    player.GetComponent<Movement>().enabled = true;

        //    this.GetComponent<TurretAnimation>().enabled = false;
        //}
    }

    //void FixedUpdate()
    //{
        
    //    if (Input.GetKey(KeyCode.E))
    //    {
            
    //        player.GetComponent<Movement>().enabled = true;

    //        this.GetComponent<TurretAnimation>().enabled = false;
    //    }
    //}

}

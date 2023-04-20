using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject turret;

    public float MovementSpeed = 1;
    public float JumpForce = 1;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        turret = GameObject.FindGameObjectWithTag("turret");
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

        //if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        //{
        //    _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        //}


    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Dome")
        {
            if (Input.GetButton("enter"))
            {
                Debug.Log("Pressed E in Dome");
                turret.GetComponent<TurretAnimation>().enabled = true;
                this.GetComponent<Movement>().enabled = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

}

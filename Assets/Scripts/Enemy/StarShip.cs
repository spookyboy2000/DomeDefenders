using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarShip : MonoBehaviour
{
    //public string Tag;
    public string Target2;
    //public float offset;

    public Transform Dome;
    public float moveSpeed = 5f;
    public float turnSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    //private Transform target;
    private Transform Target;
    //private Vector3 targetPos;
    //private Vector3 thisPos;
    //private float angle;


    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag(Target2).transform;
        rb = this.GetComponent<Rigidbody2D>();
        //target = GameObject.FindGameObjectWithTag(Tag).GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 direction = Target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
        //rotateCharacter(rb.rotation);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
        
    }

    //void rotateCharacter(Vector2 angle)
    //{
    //    rb.rotateCharacter((Vector2)transform.rotation + (angle * turnSpeed * Time.deltaTime));
    //}

    //void LateUpdate()
    //{
    //    targetPos = target.position;
    //    thisPos = transform.position;
    //    targetPos.x = targetPos.x - thisPos.x;
    //    targetPos.y = targetPos.y - thisPos.y;
    //    angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
    //    transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Dome")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }


}

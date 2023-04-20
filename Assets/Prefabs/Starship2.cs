using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starship2 : MonoBehaviour
{
    private Vector3 targetPos;
    private Vector3 thisPos;
    private float angle;
    private Transform target;
    public string Tag;
    public float offset;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag(Tag).GetComponent<Transform>();
    }

    void LateUpdate()
    {
        targetPos = target.position;
        thisPos = transform.position;
        targetPos.x = targetPos.x - thisPos.x;
        targetPos.y = targetPos.y - thisPos.y;
        angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "starcollider")
        {
            this.GetComponent<StarShip>().enabled = false;
            this.GetComponent<ShipShoot>().enabled = true;
        }
    }
}

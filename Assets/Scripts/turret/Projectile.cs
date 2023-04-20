using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if(collision.tag != "Projectile")
        //{
        //    gameObject.transform.parent = collision.gameObject.transform;
        //    Destroy(Rigidbody);
        //    GetComponent<CircleCollider2D>().enabled = false;
        //}

        if(collision.tag == "Player")
        {
            var healthComponent = collision.GetComponent<PlayerHealth>();
            if(healthComponent != null)
            {
                // TakeDamage can be switched to Heal for healing effect.
                healthComponent.TakeDamage(20);
            }
        }
    }
}

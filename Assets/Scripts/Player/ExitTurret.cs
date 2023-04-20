using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTurret : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Dome")
        {
            if (Input.GetButton("enter"))
            {
                this.GetComponent<Movement>().enabled = false;
            }
        }
    }

    //void OnTriggerStay2D(Collider2D other)
    //{
    //    if (this.GetComponent<Movement>().enabled == false)
    //    {
    //        Debug.Log("YUP");
    //        if (Input.GetButton("exit"))
    //        {
    //            this.GetComponent<Movement>().enabled = true;
    //        }
    //    }
    //}
}

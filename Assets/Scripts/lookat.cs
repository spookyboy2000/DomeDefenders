using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour
{
    public Vector3 objectPosition;
    private Vector3 diff;

    public static float speed = 5.0f;

    // Use this for initialization
    void Start()
    {

        transform.position = new Vector3(0, 25, 0);

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerPosition = GameObject.FindWithTag("object").transform.position;

        transform.position = Vector3.Lerp(transform.position, objectPosition, Time.deltaTime * speed);

    }
}

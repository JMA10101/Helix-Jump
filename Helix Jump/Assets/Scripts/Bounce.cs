using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Rigidbody ball;
    public int force;
    private Vector3 startingPoint;

    void Start()
    {
        startingPoint = ball.transform.position;
    }
    void FixedUpdate()
    {
        //vPrevPos = transform.position;
        

    }
    void OnCollisionEnter(Collision c)
    {
        //transform.position = vPrevPos;
        ball.AddForce(Vector3.up * force *1000 * Time.deltaTime);
        if (c.gameObject.layer==7)
        {
            ball.transform.position = startingPoint;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        ball.gameObject.SetActive(false);
    }
}

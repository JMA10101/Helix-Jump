using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Rigidbody ball;
    public int force;

    void FixedUpdate()
    {
        //vPrevPos = transform.position;
        

    }
    void OnCollisionEnter(Collision c)
    {
        //transform.position = vPrevPos;
        ball.AddForce(Vector3.up * force  * Time.deltaTime);
    }
}

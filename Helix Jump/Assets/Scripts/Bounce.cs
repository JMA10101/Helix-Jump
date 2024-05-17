using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Rigidbody ball;
    public int force;
    private Vector3 startingPoint;
    public GameObject topLayer;

    
    public int level;

    void Start()
    {
        startingPoint = ball.transform.position;
    }
    void FixedUpdate()
    {
        int topHeight= Mathf.CeilToInt(topLayer.transform.position.y / 10.0f);
        int currentY = Mathf.CeilToInt(ball.transform.position.y/10.0f);
        level = topHeight - currentY;

    }
    void OnCollisionEnter(Collision c)
    {
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

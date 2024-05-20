using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bounce : MonoBehaviour
{
    public Rigidbody ball;
    public int force;
    private Vector3 startingPoint;
    public GameObject topLayer;
    public int currentLevel;
    private int lastTouch = 0;
    public int streak = 0;
    public bool canDie = true;
    private Material startMaterial;
    public Material streakMaterial;




    void Start()
    {
        startMaterial = ball.GetComponent<Renderer>().material;
        startingPoint = ball.transform.position;
    }
    void FixedUpdate()
    {
        int topHeight= Mathf.CeilToInt(topLayer.transform.position.y / 10.0f);
        int currentY = Mathf.CeilToInt(ball.transform.position.y/10.0f);
        currentLevel = topHeight - currentY;
        streak = currentLevel-lastTouch;
        if (streak>2)
        {
            ball.gameObject.GetComponent<Renderer>().material = streakMaterial;
        }
        else
        {
            ball.gameObject.GetComponent<Renderer>().material = startMaterial;
        }

    }
    void OnCollisionEnter(Collision c)
    {
       
        if (streak>=3)
        {
            c.gameObject.SetActive(false);
        }
        lastTouch = currentLevel;
        ball.AddForce(Vector3.up * force *1000 * Time.deltaTime);
        if (c.gameObject.layer==7)
        {
            ball.transform.position = startingPoint;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (canDie)
        {
            SceneManager.LoadScene(1);
            //ball.gameObject.SetActive(false);
        }

    }
}

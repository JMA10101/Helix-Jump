using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject ball;
    public GameObject camera;
    public float yOffset = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position=new Vector3(transform.position.x, ball.transform.position.y+yOffset, transform.position.z);
    }
}

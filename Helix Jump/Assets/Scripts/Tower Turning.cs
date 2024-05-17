using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTurning : MonoBehaviour
{
    public float speed = 200.0f;
    public float sens = 50.0f;
    public GameObject layer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 v3 = new Vector3(0.0f, 0.0f, Input.GetAxis("Horizontal"));
        layer.transform.Rotate(0.0f, -1.0f*Input.GetAxis("Mouse X") * speed*sens* Time.deltaTime, 0.0f);
    }
}

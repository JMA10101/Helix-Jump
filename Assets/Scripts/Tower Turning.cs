using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTurning : MonoBehaviour
{
    public float speed = 200.0f;
    public float sens = 40.0f;
    public GameObject layer;
    public bool useMouse = true;
    public GameObject control;

    // Start is called before the first frame update
    void Start()
    {
        useMouse = control.CompareTag("Untagged");
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 v3 = new Vector3(0.0f, 0.0f, Input.GetAxis("Horizontal"));
        if (useMouse)
        {
            layer.transform.Rotate(0.0f, -1.0f * Input.GetAxis("Mouse X") * speed * sens * Time.deltaTime, 0.0f);
        }            
        else
        {
            layer.transform.Rotate(0.0f, 1.0f * Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0.0f);
        }
    }
}

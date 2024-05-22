using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Win : MonoBehaviour
{
    public TMP_Text t;
    // Start is called before the first frame update
    void Start()
    {
        t.text = (Bounce.timer).ToString("0.00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

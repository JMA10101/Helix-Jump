using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Menu : MonoBehaviour
{

    public GameObject control;
    public static bool useMouse=true;
    public TMP_Text t;
    public Slider slider;
    public static float multiplier;
    

    // Start is called before the first frame update
    void Start()
    {
        slider.value = multiplier;
        
        
        
        //multiplier = slider.value;
    



    }

    // Update is called once per frame
    void Update()
    {
        
        multiplier = slider.value;
        slider.value = multiplier;


        if (useMouse)
        {
            t.text = "Mouse";
            
        }
        else
        {
            t.text = "Arrows";
        }
        //control.transform.position = new Vector3(slider.value, 0, 0);
    }

    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }

    public void OnMouseButton()
    {
        useMouse = !useMouse;
       
    }
    public void EndButton()
    {
        SceneManager.LoadScene(0);
    }

    

}

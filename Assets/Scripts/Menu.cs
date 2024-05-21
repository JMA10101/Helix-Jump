using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Menu : MonoBehaviour
{

    public GameObject control;
    public bool useMouse=true;
    public TMP_Text t;

    // Start is called before the first frame update
    void Start()
    {
        useMouse= control.CompareTag("Untagged");

    }

    // Update is called once per frame
    void Update()
    {
        if (useMouse)
        {
            t.text = "Mouse";
            control.tag = "Untagged";
        }
        else
        {
            t.text = "Arrows";
            control.tag = "Respawn";
        }
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

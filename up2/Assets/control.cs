using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    // Start is called before the first frame update
    bool paused = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (paused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void pause()
    {
        paused = !paused;
    }

    public void mainmenu()
    {
        // this should load the main menu todo:: hatem
    }
}

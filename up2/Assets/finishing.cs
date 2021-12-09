using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class finishing : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayableDirector dir;
    void awake()
    {
        
        dir = GetComponent<PlayableDirector>();
        dir.played += Dir_played;
        dir.stopped += dir_stopped; 
    }
    public void Dir_played(PlayableDirector l)
    {
        
    }

    public void dir_stopped(PlayableDirector l)
    {
        // loads the main menu todo=> hatem
    }
    

}

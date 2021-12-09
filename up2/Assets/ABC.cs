using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
public class ABC : MonoBehaviour
{
    private PlayableDirector dir;
    public PlayableDirector gun_timeline;
    public PlayableDirector grenade_timeline;
    public GameObject canvus;
    public GameObject hero_norm;
    public GameObject hero_gun;
    public GameObject hero_grenade;
    public  AudioSource audioData;
    // bool fin = false;
        void Awake()
    {
        canvus.SetActive(false);
        hero_gun.SetActive(false);
        hero_grenade.SetActive(false);
        dir = GetComponent<PlayableDirector>();
        dir.played += Dir_played;
        dir.stopped += dir_stopped;
        
        
    }

    
    public void Dir_played(PlayableDirector l)
    {
        
    }

    public void dir_stopped(PlayableDirector l)
    {
        canvus.SetActive(true);
        audioData.Play(0);
    }
    void Update()
    {
    
    }
    public void gun_pressed()
    {
        audioData.Pause();
        canvus.SetActive(false);
        hero_norm.SetActive(false);
        hero_gun.SetActive(true);
        gun_timeline.Play();
    }
    public void grenade_pressed()
    {
        audioData.Pause();
        canvus.SetActive(false);
        hero_norm.SetActive(false);
        hero_grenade.SetActive(true);
        grenade_timeline.Play();
    }
}
 
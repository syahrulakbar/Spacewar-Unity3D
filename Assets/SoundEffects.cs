using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{

    public AudioSource deathSong;

    public bool DeathSong = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.health <= 0)
        {
            DeathSound();
        }
    }


    public void DeathSound()
    {
        deathSong.Play();
        DeathSong = true;
    }
}

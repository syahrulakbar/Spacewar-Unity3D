using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource backsound;
    public GameObject soundOn, soundOff;

    private void Start()
    {
        soundOff.SetActive(false);

    }
    public void SoundOn()
    {
        backsound.Play();
        soundOn.SetActive(true);
        soundOff.SetActive(false);


    }
    public void SoundOff()
    {
        backsound.Stop();
        soundOff.SetActive(true);
        soundOn.SetActive(false);

    }
}

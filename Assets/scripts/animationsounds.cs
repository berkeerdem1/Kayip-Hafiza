using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationsounds : MonoBehaviour
{
    public AudioSource walkses;
    public AudioSource runses;
    public AudioSource ziplamases;
    public AudioSource sarjorses;
    //public AudioSource olumses;

    void walksound()
    {
        walkses.Play();
    }
    void runsound()
    {
        runses.Play();

    }
    void deathsound()
    {
        //olumses.Play();
    }
    void deathsoundstop()
    {
        //olumses.Stop();
    }
    void jumpsound()
    {
        ziplamases.Play();
    }
    void reloadsound()
    {
        sarjorses.Play();
    }

}

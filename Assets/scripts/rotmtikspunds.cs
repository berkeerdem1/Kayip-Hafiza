using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotmtikspunds : MonoBehaviour
{
    public AudioSource olumses;
    public AudioSource yurumeses;
    public AudioSource kosmases;
    public AudioSource sarjorses;
    public AudioSource ziplamases;
    void deathsound()
    {
        olumses.Play();
    }
    void deathsoundstop()
    {
        //olumses.Stop();
    }
    void walksound()
    {
        yurumeses.Play();
    }
    void runsound()
    {
        kosmases.Play();
    }
    void reloadsound()
    {
        sarjorses.Play();
    }
    void jumpsound()
    {
        ziplamases.Play();
    }

}

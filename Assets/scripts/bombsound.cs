using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombsound : MonoBehaviour
{
    public AudioSource patlamacam;

    void Start()
    {
        patlamacam = GetComponent<AudioSource>();
    }
    void bombcam(AudioClip clip)
    {
        patlamacam.PlayOneShot(clip);
    }
}

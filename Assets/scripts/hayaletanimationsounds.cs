using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hayaletanimationsounds : MonoBehaviour
{
    public AudioSource attackses;
    public AudioSource olumses;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void isiriksound()
    {
        attackses.Play();
    }
    void olumsound()
    {
        olumses.Play();
    }
}

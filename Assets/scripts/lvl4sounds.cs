using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl4sounds : MonoBehaviour
{
    public static AudioClip scenesound;
    static AudioSource audiosrc;
    void Start()
    {
        scenesound=Resources.Load<AudioClip>("scenesound");
        audiosrc=GetComponent<AudioSource>();
    }

    public static void playersound(string clip){
        switch(clip){
            case "scenesound":
                audiosrc.PlayOneShot(scenesound);
                break;
        }
    }
}

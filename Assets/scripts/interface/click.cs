using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip clickk;

    public static click sfxinstance;

    private void awake(){
        if(sfxinstance != null && sfxinstance != this){
            Destroy(this.gameObject);
            return;
        }
        sfxinstance=this;
        DontDestroyOnLoad(this);
    }
    
}


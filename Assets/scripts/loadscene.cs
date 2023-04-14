using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadscene : MonoBehaviour
{
    private int nextscenetoload;


    //public LayerMask playerLayers;
    void Start()
    {
        nextscenetoload = SceneManager.GetActiveScene().buildIndex + 1;
    }




    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "player")
        {
            SceneManager.LoadScene(nextscenetoload);
            //Debug.Log("sahne sonu");
        }
    }
}

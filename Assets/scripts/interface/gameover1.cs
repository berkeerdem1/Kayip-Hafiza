using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameover1 : MonoBehaviour
{
    private int nextscenetoload;
    public void bolumBasi()
    {
        //nextscenetoload = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(8);
    }
    public void anaMenu()
    {

        SceneManager.LoadScene(0);
    }
    public void Quit()
    {

        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ilkson : MonoBehaviour
{
    private int nextscenetoload;
    public void secenekekrani()
    {
        //nextscenetoload = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(4);
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

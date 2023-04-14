using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class bossdeath_gameover : MonoBehaviour
{
    private int nextscenetoload;
    public void secenekekrani()
    {
        SceneManager.LoadScene(21);
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


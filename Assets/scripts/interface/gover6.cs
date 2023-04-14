using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gover6 : MonoBehaviour
{
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

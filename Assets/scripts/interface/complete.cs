using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class complete : MonoBehaviour
{

    public void yenioyun()
    {
        //nextscenetoload = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(29);
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

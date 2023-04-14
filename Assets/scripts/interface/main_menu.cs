using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{

    public void baslaButton()
    {
        SceneManager.LoadScene(1);
    }
    public void ayarButton()
    {
        SceneManager.LoadScene(38);
    }

    public void cikButton()
    {
        Application.Quit();
    }
}

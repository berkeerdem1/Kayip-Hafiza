using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pauseMenu : MonoBehaviour
{
    public static bool isPaused = false;


    void Start()
    {
        //PauseMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // if(isPaused){
            // 	resumegame();
            // }
            // else{
            // 	pausegame();
            // }
            SceneManager.LoadScene(41);
        }
    }

    public void pausegame()
    {
        //GoToMainMenu();
        SceneManager.LoadScene(41);
    }
    // public void resumegame(){
    // 	//PauseMenu.SetActive(false);
    // 	Time.timeScale=1f;
    // }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void quitgame()
    {
        Application.Quit();
    }
}

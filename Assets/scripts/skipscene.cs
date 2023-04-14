using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class skipscene : MonoBehaviour
{
    private int nextscenetoload;
    void Start()
    {
        nextscenetoload = SceneManager.GetActiveScene().buildIndex + 1;
    }
    public void gec()
    {
        SceneManager.LoadScene(nextscenetoload);
    }
}

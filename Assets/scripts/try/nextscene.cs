using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nextscene : MonoBehaviour
{

    void OnCollision2D(Collision2D col)
    {
        if (col.gameObject.tag == "player")
        {
            SceneManager.LoadScene(2);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public GameObject tutorialtext;
    public GameObject image;


    void Start()
    {
        tutorialtext.SetActive(false);
        image.SetActive(false);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        tutorialtext.SetActive(true);
        image.SetActive(true);

    }

    // Update is called once per frame
    private void OnTriggerExit2D(Collider2D collision)
    {
        tutorialtext.SetActive(false);
        image.SetActive(false);

    }
}

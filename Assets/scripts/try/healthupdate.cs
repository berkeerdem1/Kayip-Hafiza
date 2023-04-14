using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthupdate : MonoBehaviour
{
    private Rigidbody2D rb;
    private robert_health health;
    public GameObject image;

    public healthbar Healthbar;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = GetComponent<robert_health>();
        Healthbar = GetComponent<healthbar>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        // tutorialtext.SetActive(true);
        image.SetActive(true);
        health.currentHealth += 30;
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        image.SetActive(false);

    }

}

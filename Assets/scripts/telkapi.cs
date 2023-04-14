using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telkapi : MonoBehaviour
{
    private Animator animator;
    public float maxHealth = 20;
    public float currentHealth;
    void Start()
    {
        currentHealth = maxHealth;

        animator = GetComponent<Animator>();
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;



        if (currentHealth <= 0)
        {

            currentHealth = 0;
            Die();
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            //animator.SetTrigger("yikim");
            Destroy(gameObject, 0.15f);
        }
    }
    void Die()
    {


        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}

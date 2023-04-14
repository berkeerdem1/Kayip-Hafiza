using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

    public Transform Firepoint;
    public GameObject Bullet;

    Rigidbody2D rb;


    [SerializeField]
    private GameObject[] ammo;

    private int ammoAmount;
    public Animator animator;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        for (int i = 0; i <= 7; i++)
        {
            ammo[i].gameObject.SetActive(true);
        }
        ammoAmount = 8;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammoAmount > 0)
        {
            Shoot();

            ammoAmount -= 1;
            ammo[ammoAmount].gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.R))
        {
            ammoAmount = 8;
            for (int i = 0; i <= 7; i++)
            {
                ammo[i].gameObject.SetActive(true);
            }
        }

    }
    void Shoot()
    {

        Instantiate(Bullet, Firepoint.position, Firepoint.rotation);
    }


}

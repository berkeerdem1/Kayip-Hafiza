using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rober3_walk : MonoBehaviour
{
    public int speed;

    Animator animator;
    Rigidbody2D rb;
    Vector2 forward;
    public Vector3 offset;
    RaycastHit2D hit;

    bool faceRight = true;

    public bool canjump = true;
    public int jumpSpeed = 5;


    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();


    }

    private void FixedUpdate()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        // if (Input.GetKeyDown(KeyCode.E))
        // {
        //     animator.SetBool("gunchange", true);

        // }
        // if (Input.GetKeyDown(KeyCode.Q))
        // {
        //     animator.SetBool("gunchange", false);
        // }


        if (moveInput > 0 || moveInput < 0)
        {
            animator.SetBool("iswalking", true);
            // walkses.SetActive(true);
        }
        else
        {
            animator.SetBool("iswalking", false);

        }

        animator.SetBool("isjump", false);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //canjump = true;
            jump();
            animator.SetBool("isjump", true);
            canjump = false;
        }

        if (faceRight == true && moveInput < 0)
        { //ÖNEMLi
            Flip();
        }
        else if (faceRight == false && moveInput > 0)
        {
            Flip();
        }

    }
    void Flip() //KARAKTERi X EKSENiNDE TERS YÖNE DÖNDÜRME
    {
        faceRight = !faceRight;
        transform.Rotate(new Vector3(0, 180, 0));
    }
    //sola döndürme
    public bool getfaceRight()
    {
        return faceRight;
    }
    private void jump()
    {
        if (canjump)
        {
            //rb.AddForce(Vector2.up * jumpSpeed);
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            canjump = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.transform.tag == "platform"))
        {
            canjump = true;
        }

    }
}

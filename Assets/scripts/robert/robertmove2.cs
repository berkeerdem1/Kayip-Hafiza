using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class robertmove2 : MonoBehaviour
{
    public int speed;
    public float faster;

    Animator animator;
    Rigidbody2D rb;

    Vector2 forward;
    public Vector3 offset;
    RaycastHit2D hit;

    bool faceRight = true;

    shothun_boxammo shotgunbox;

    public bool canjump = true;
    public int jumpSpeed = 5;


    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        shotgunbox = GetComponent<shothun_boxammo>();
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
            animator.SetBool("walkgun2", true);

            if (Input.GetButtonDown("Fire1"))
            {
                animator.SetBool("walksarjor", true);
            }
            animator.SetBool("walksarjor", false);


            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity = new Vector2(moveInput * faster, rb.velocity.y);
                animator.SetBool("rungun2", true);

            }
            else
            {
                animator.SetBool("rungun2", false);
            }

        }
        else
        {
            animator.SetBool("walkgun2", false);
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
    void Flip()
    {  //KARAKTERi X EKSENiNDE TERS YÖNE DÖNDÜRME
        faceRight = !faceRight;
        //Vector3 scaler=transform.localScale;
        //scaler.x*=-1;
        //transform.localScale=scaler;
        transform.Rotate(new Vector3(0, 180, 0));

    }
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

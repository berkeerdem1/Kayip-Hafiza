using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public Vector2 pos1;
    public Vector2 pos2;


    public float leftrightspeed;
    private float oldposition;
    public float distance;
    private Animator animator;
    private Transform target;
    public float followspeed;
    public enemy_combat enemycombat;

    //public robert_health Robert_Health;






    void Start()
    {
        Physics2D.queriesStartInColliders = false;
        target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
        animator = GetComponent<Animator>();
        enemycombat = GetComponent<enemy_combat>();
        //Robert_Health = GetComponent<robert_health>();



    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * leftrightspeed, 1.0f));

        if (transform.position.x > oldposition)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);

        }
        if (transform.position.x < oldposition)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        oldposition = transform.position.x;
        enemyai();
        //enemyFollow();
    }
    void enemyai()
    {
        RaycastHit2D hitenemy = Physics2D.Raycast(transform.position, -transform.right, distance);
        if (hitenemy.collider != null && hitenemy.collider.gameObject.tag == "player")
        {
            Debug.DrawLine(transform.position, hitenemy.point, Color.red);
            animator.SetBool("isAttack", true);
            enemyFollow();
            enemycombat.DamagePlayer();
            Debug.Log(" takip ediyor " + transform.position);
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position - transform.right * distance, Color.green);
            animator.SetBool("isAttack", false);

        }

    }
    void enemyFollow()
    {
        Vector3 targetposition = new Vector3(target.position.x, gameObject.transform.position.y, target.position.x);
        transform.position = Vector2.MoveTowards(transform.position, targetposition, followspeed * Time.deltaTime);


    }

}

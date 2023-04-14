using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemycombat2 : MonoBehaviour
{
    public Transform enemyAttackPoint;

    //public LayerMask playerLayers;

    public float enemyAttackRange = 0.5f;
    public int enemyAttackDamage = 40;


    public void DamagePlayer()
    {


        // Collider2D[] hitenemies = Physics2D.OverlapCircleAll(enemyAttackPoint.position, enemyAttackRange, playerLayers);
        // foreach (Collider2D enemy in hitenemies)
        // {
        //     enemy.GetComponent<robert_health>().TakeDamage(enemyAttackDamage);

        // }

        Collider2D[] hitenemies = Physics2D.OverlapCircleAll(enemyAttackPoint.position, enemyAttackRange);


        foreach (Collider2D enemy in hitenemies)
        {



            //4.LEVELDEKİ ROBERT'IN CAN KODU
            if (enemy.GetComponent<roberthealth2>())
            {
                enemy.GetComponent<roberthealth2>().TakeDamage(enemyAttackDamage);
            }


        }
    }




    private void OnDrawGizmosSelected()
    {
        if (enemyAttackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(enemyAttackPoint.position, enemyAttackRange);
    }
}

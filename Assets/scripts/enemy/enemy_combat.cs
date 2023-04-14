using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy_combat : MonoBehaviour
{
    public Transform enemyAttackPoint;
    //public LayerMask playerLayers;


    public float enemyAttackRange = 0.5f;
    public int enemyAttackDamage = 20;



    public void DamagePlayer()
    {
        // Collider2D[] hitenemies = Physics2D.OverlapCircleAll(enemyAttackPoint.position, enemyAttackRange, playerLayers);
        // foreach (Collider2D enemy in hitenemies)
        // {
        //     enemy.GetComponent<roberthealth2>().TakeDamage(enemyAttackDamage);
        // }

        Collider2D[] hitenemies = Physics2D.OverlapCircleAll(enemyAttackPoint.position, enemyAttackRange);

        foreach (Collider2D enemy in hitenemies)
        {

            //1-3.LEVELDEKİ ROBERT'IN CAN KODU
            if (enemy.GetComponent<robert_health>())
            {
                //enemy.isTrigger = true;
                enemy.GetComponent<robert_health>().TakeDamage(enemyAttackDamage);
            }

            //Debug.Log(enemy.transform.position);

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

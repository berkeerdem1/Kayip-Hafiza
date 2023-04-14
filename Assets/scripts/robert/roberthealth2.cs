using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class roberthealth2 : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public healthbar healthbar;

    public bool enemyattack;
    public float enemytimer;
    public Animator animator;


    public GameObject[] medicine2;
    private int medicineAmount2;
    public int allmedicine2 = 1;
    public TextMeshProUGUI canyazi;


    void Start()
    {
        int i = 0;
        currentHealth = maxHealth;
        enemytimer = 1.5f;
        animator = GetComponent<Animator>();


        for (; i < 1; i++)
        {
            medicine2[i].gameObject.SetActive(true);
        }
        medicineAmount2 = 1;
    }
    //düşmanın zarar verme aralığı
    void enemeyAttackSpacing()
    {
        if (enemyattack == false)
        {
            enemytimer -= Time.deltaTime;
        }
        if (enemytimer < 0)
        {
            enemytimer = 0f;
        }
        if (enemytimer == 0f)
        {
            enemyattack = true;
            enemytimer = 1.5f;
        }
    }
    //düşmanı kitleme
    void characterDamage()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            enemyattack = false;
        }
    }
    //karakterin zarar görmesi
    public void TakeDamage(int damage)
    {
        if (enemyattack)
        {
            currentHealth -= 20;
            canyazi.text = "can:100/" + currentHealth;
            enemyattack = false;
        }
        healthbar.setHealth(currentHealth);

        if (currentHealth <= 0)
        {
            //animator.SetBool("isDie", true);
            animator.SetTrigger("isDie");
            Time.timeScale = 1.5f;

            currentHealth = 0;
            //dead();
            StartCoroutine(waiter());
        }


    }

    public void dead()
    {
        GetComponent<robertmove2>().enabled = false;

        Destroy(gameObject, 1f);



        SceneManager.LoadScene(14);
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        dead();
    }


    // Update is called once per frame
    void Update()
    {
        enemeyAttackSpacing();
        characterDamage();

        if (
                allmedicine2 > 0 &&
                Input.GetKeyDown(KeyCode.X) &&
                currentHealth != 100 && allmedicine2 > 0
          )
        {

            currentHealth += 40;
            healthbar.setHealth(currentHealth);
            canyazi.text = "can:100/" + currentHealth;

            medicineAmount2 -= 1;
            allmedicine2 -= 1;
            medicine2[medicineAmount2].gameObject.SetActive(false);
        }

    }

}

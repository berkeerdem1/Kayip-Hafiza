using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class rotomatik_health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public healthbar healthbar;

    public bool enemyattack;
    public float enemytimer;
    public Animator animator;


    public GameObject[] medicine;
    private int medicineAmount;
    public int allmedicine = 1;

    public GameObject ilac;
    public TextMeshProUGUI canyazi;


    void Start()
    {
        int i = 0;
        currentHealth = maxHealth;
        enemytimer = 1.5f;
        animator = GetComponent<Animator>();

        for (; i <= 1; i++)
        {
            medicine[i].gameObject.SetActive(true);
        }
        medicineAmount = 2;
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
            animator.SetBool("isdie", true);
            Time.timeScale = 1.5f;
            currentHealth = 0;
            //dead();
            StartCoroutine(waiter());
        }


    }

    public void dead()
    {
        GetComponent<rotomatik_move>().enabled = false;

        Destroy(gameObject, 1.5f);

        SceneManager.LoadScene(37);
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
                allmedicine > 0 &&
                Input.GetKeyDown(KeyCode.X) &&
                currentHealth != 100 && allmedicine > 0
          )
        {

            currentHealth += 20;
            healthbar.setHealth(currentHealth);
            canyazi.text = "can:100/" + currentHealth;
            medicineAmount -= 1;
            allmedicine -= 1;
            medicine[medicineAmount].gameObject.SetActive(false);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("medicine")&& currentHealth != 100 )
        {
            Destroy(ilac);
            currentHealth = maxHealth;
            healthbar.setHealth(currentHealth);
            canyazi.text = "can:100/" + currentHealth;
        }
    }

}

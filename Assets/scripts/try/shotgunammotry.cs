using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotgunammotry : MonoBehaviour
{
    bool faceRight = true;

    private int ammoAmount;

    public GameObject bullet;
    public Transform firepoint;
    private float bulletspeed = 50f;
    public GameObject[] ammo;
    void Update()
    {
        //faceRight = GetComponent<robert_move>();
        faceRight = GetComponent<robertmove2>().getfaceRight();

        if (Input.GetButtonDown("Fire1") && ammoAmount > 0)
        {
            weaponfire();
        }
    }
    private void weaponfire()
    {
        if (faceRight == true)
        {
            for (int i = 0; i <= 3; i++)
            {

                var spawnedBullet = Instantiate(bullet, firepoint.position, firepoint.rotation);
                spawnedBullet.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 2000f);

                //spawnedBullet.AddForce(firepoint.up * bulletspeed);
                spawnedBullet.GetComponent<Rigidbody2D>().AddForce(firepoint.up * bulletspeed);


                switch (i)
                {
                    case 0:
                        spawnedBullet.GetComponent<Rigidbody2D>().AddForce(firepoint.up * bulletspeed + new Vector3(0f, -90f, 0f));
                        //spawnedBullet.AddForce(firepoint.up * bulletspeed + new Vector3(0f, -90f, 0f));
                        break;
                    case 1:
                        spawnedBullet.GetComponent<Rigidbody2D>().AddForce(firepoint.up * bulletspeed + new Vector3(0f, 0f, 0f));
                        //spawnedBullet.AddForce(firepoint.up * bulletspeed + new Vector3(0f, 0f, 0f));
                        break;
                    case 2:
                        spawnedBullet.GetComponent<Rigidbody2D>().AddForce(firepoint.up * bulletspeed + new Vector3(0f, 0f, 0f));
                        //spawnedBullet.AddForce(firepoint.up * bulletspeed + new Vector3(0f, 90f, 0f));
                        break;
                    case 3:
                        spawnedBullet.GetComponent<Rigidbody2D>().AddForce(firepoint.up * bulletspeed + new Vector3(0f, 90f, 0f));
                        //spawnedBullet.AddForce(firepoint.up * bulletspeed + new Vector3(0f, 90f, 0f));
                        break;


                }

            }
        }
        else
        {
            var spawnedBullet = Instantiate(bullet, firepoint.position, firepoint.rotation);
            spawnedBullet.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 2000f);
        }


        ammoAmount -= 1;
        ammo[ammoAmount].gameObject.SetActive(false);

        if (Input.GetKey(KeyCode.R))
        {
            ammoAmount = 4;
            for (int i = 0; i <= 3; i++)
            {
                ammo[i].gameObject.SetActive(true);
            }
        }
    }

}

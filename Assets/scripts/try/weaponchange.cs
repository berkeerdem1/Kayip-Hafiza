using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponchange : MonoBehaviour
{
    int totalweapons = 1;
    public int currentWeaponIndex;

    public GameObject[] guns;
    public GameObject weaponholder;
    public GameObject currentgun;

    void Start()
    {
        totalweapons = weaponholder.transform.childCount;
        guns = new GameObject[totalweapons];

        for (int i = 0; i < totalweapons; i++)
        {
            guns[i] = weaponholder.transform.GetChild(i).gameObject;
            guns[i].SetActive(false);
        }
        guns[0].SetActive(true);
        currentgun = guns[0];
        currentWeaponIndex = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            guns[currentWeaponIndex].SetActive(false);
            currentWeaponIndex += 1;
            guns[currentWeaponIndex].SetActive(true);
            currentgun = guns[currentWeaponIndex];
            if (currentWeaponIndex > 1)
            {
                currentWeaponIndex = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            guns[currentWeaponIndex].SetActive(false);
            currentWeaponIndex -= 1;
            guns[currentWeaponIndex].SetActive(true);
            currentgun = guns[currentWeaponIndex];

            if (currentWeaponIndex < 0)
            {
                currentWeaponIndex = 1;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip_Gun : MonoBehaviour
{

    public GameObject inventory;

    public GameObject[] weapons;

    GameObject currentGun;

    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonClickDetection()
    {
        
    }

    public void SelectWeapon(int choice)
    {
        if (currentGun != null)
        {
            currentGun.SetActive(false);
        }

        currentGun = weapons[choice];
        currentGun.SetActive(true);
            
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "new Weapon", menuName = "Weapons")]
public class Weapon : WeaponAttributes
{
    public GameObject prefab;

    //How many bullets are in a magazine
    public int magazineSize;

    //How many magazine are you able to carry
    public int magazineCount;

    //Weapon range (more important to melee)
    public int range;

    //Weapon Type
    public WeaponType weaponType;
}

public enum WeaponType {Melee, Handguns, Assault_Rifles, Shotguns, Sniper_Rifles, SMGs, PDWs, DMRs, Light_Machine_Guns}
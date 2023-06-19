using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lock_Cursor : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    public void ButtonPressed()
    {
        //Debug.Log("Button pressed");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}

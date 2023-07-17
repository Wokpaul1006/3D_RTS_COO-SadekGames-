using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineerCS : BaseUnit
{
    //This unit is light infantry, play a role that capture building, healing, cant attack any type of enemy
    [SerializeField] Rigidbody body;
    public GameObject target;
    private int abillityCountdown;

    // Start is called before the first frame update
    void Start()
    {
        UnitNames = "UIPM_Inf03";
        atkDmg = 5;
        atkRange = 5;
        atkSp = 5;

        abillityCountdown = 0;
    }

    // Update is called once per frame
    public void Bride()
    {
        //Do bride action
        if (abillityCountdown == 10)
        {
            //do Bride action
        }
        else { }
    }

    private void Update()
    {
        abillityCountdown = ((int)Time.time);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OiranMermaidSC : BaseUnit
{
    //This unit is support infantry, play a role that healing unit, capture structure, cant attack any type of enemy
    [SerializeField] Rigidbody body;
    private float TakenDmg;
    public GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        UnitNames = "NEA_Inf03";
        atkDmg = 5;
        atkRange = 5;
        atkSp = 5;
    }

    private IEnumerator AutoHealing(){
        //Do Healing anim
        //Minus 30% mana
        //Plus full HP for target
        yield return new WaitForSeconds(1f);
        //Do healing code for allied unit on range
        StartCoroutine(AutoHealing());
    }

    public void UnPackHospital()
    {
        //Change model to a hospital
        StartCoroutine(AutoHealing());
    }

    public void PackHospital()
    {
        //Change model ack to oiranmermaid
        StopAllCoroutines();
    }
}
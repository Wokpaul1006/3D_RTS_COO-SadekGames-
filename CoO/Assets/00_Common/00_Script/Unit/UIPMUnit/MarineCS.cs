using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MarineCS : BaseUnit
{
    //This unit is light infantry, play a role that attack on infantry and ligt Aircraft less effective on Armored and other type of Aircraft
    [SerializeField] Rigidbody body;
    private float TakenDmg;
    public GameObject target;
    private bool onMelee = false;

    BaseUnit unit = new BaseUnit();
    // Start is called before the first frame update
    void Start()
    {
        UnitNames = "UIPM_Inf01";

        atkSp = 5;
        atkDmg = 5;
        atkRange = 5;
        unitSp = 5;

        AddRigidBody();
    }

    // Update is called once per frame
    void LateUpdate()
    {
    }

    private void CalExp()
    {

    }

    private void CheckRank()
    {

    }

    private void CheckUnitHealth ()
    {

    }

    private void CalUnitDmg()
    {
    }

    private void CalTakeDmg()
    {
        //Dmg Taken = Enemy FinalDmg - UnitArmor
    }
    private void UseAbility()
    { 
        onMelee = true;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarantulasCS : BaseUnit
{
    //This unit is light infantry, play a role that attack on armor and aircraft, less effective on infantry
    [SerializeField] Rigidbody body;
    private float TakenDmg;
    public GameObject target;

    BaseUnit unit = new BaseUnit();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckRank();
        CheckUnitHealth();
    }

    private void CalExp()
    {

    }

    private void CheckRank()
    {
        
    }

    private void CheckUnitHealth()
    {

    }

    private void CalUnitDmg()
    {
        //FinalDmg depend on BasePhyDmg, UpPhyDmg, BaseMagDmg, UpMagdmg

    }

    private void CalTakeDmg()
    {
        //Dmg Taken = Enemy FinalDmg - UnitArmor
    }
    private void UseAbility()
    { }
}

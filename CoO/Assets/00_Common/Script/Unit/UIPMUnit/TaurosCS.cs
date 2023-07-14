using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tauros : BaseUnit
{
    //This unit is MBT, play a role that anti armor vehicle, vulnerable to aircraft and artillery and hier tier unit
    [SerializeField] Rigidbody body;
    private float TakenDmg;
    public GameObject target;

    BaseUnit unit = new BaseUnit();
    // Start is called before the first frame update
    void Start()
    {
        UnitNames = "TaurosTank";
        atkSp = 5;
        atkDmg = 5;
        unitSp = 5;
        atkRange = 5;
    }

    private void Attack(){
        OnAtk(atkSp);
    }
}

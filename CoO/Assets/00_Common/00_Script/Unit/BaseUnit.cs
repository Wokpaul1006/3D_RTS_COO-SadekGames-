using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BaseUnit : MonoBehaviour
{
    protected Rigidbody rb;
    protected bool isAmphibious;

    #region Basic attribute
    protected string UnitNames;
    protected float baseHP; //Define unit's base HP
    protected float baseArmor;
    protected float unitSp; //Define unit's mve speed
    #endregion

    #region Attack Attribute
    protected float atkSp; //Define unit's attack speed
    protected float atkDmg; //Define unit's attack damage
    protected float atkRange; //Define unit's attack range
    #endregion

    public void OnCreate()
    {   }

    public void OnDead(int BaseHP)
    {
        if (BaseHP == 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnAtk(float atksp)
    {   }

    public void OnIdle()
    {   }

    public void OnFlee()
    {   }

    public void OnMove(float speed)
    {
        rb.useGravity = true;
        rb.isKinematic = false;
    }

    public void AddRigidBody()
    {
        if(!rb){
            rb = gameObject.AddComponent<Rigidbody>();
        }

        rb.useGravity = false;
        rb.isKinematic = true;
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    //#region Meaning of properties
    //UnitTags = Define what kind of unit is
    //UnitNames = Name of unit
    //UnitPurpose = Define what unit does
    //UnitType = Defint unit that they are physical damage, magical damage of hybird damage
    //#endregion
}

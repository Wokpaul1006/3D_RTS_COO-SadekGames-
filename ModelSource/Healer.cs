using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : Citizen
{
    // Start is called before the first frame update

    public bool isShow;
    #region Data
    BehaviourDataHealer data;


    protected override void LoadData()
    {
        base.LoadData();
        data = new BehaviourDataHealer(this);
        InitDataAI(new Vector3(data.walkZX, data.walkZY, data.walkZZ), data.currentSpeed, data.fleeSpeed, data.healingSpeed, data.healingValue, data.healingRange);
        enemyTags = data.fleeTags;
    }
    #endregion

    #region normal condition
    protected override bool CanFlee()
    {
        return data.canFlee && data.fleeTags.Count > 0;
    }


    protected override bool FleeToAttack()
    {
        return data.fleeToAttack;
    }

    protected override bool OnTarget(GameObject go)
    {
        return (state == AIState.RunToTarget || state == AIState.Heal) && base.OnTarget(go);
    }

    #endregion

    #region Healer 

    protected override IEnumerator Start()
    {
        yield return base.Start();

        if (data.healTags.Count > 0)
            AddDetection(data.healDectection, OnTargetEnter, null, OnTargetExit);
    }

    protected override void OnTargetExit(GameObject obj)
    {
        if (target == obj) NextAction();
    }
    protected override void OnTargetEnter(GameObject obj)
    {
        
        if (CanDoAction(obj))
        {
            target = obj;
            RunToTarget();
        }
    }

    protected override bool CanDoAction(GameObject go)
    {
        if (target) return false;

        IGameObject iGo = go.GetComponent<IGameObject>();
        if (iGo == null || iGo.GetIHeal() == null || !iGo.GetIHeal().isHealAble()) return false;
        
        return Utility.CheckHasTag(iGo.GetListTags(), data.healTags);
    }

    protected override bool CanDoAction()
    {
        return base.CanDoAction() && GetTargetIHeal.isHealAble();
    }

    protected override void NextAction()
    {
        if (state == AIState.RunToTarget || state == AIState.Heal)
        {
            if (CanDoAction())
            {
                Heal();
            }
            else Idle();

            return;
        }

        base.NextAction();
    }

    protected void Heal()
    {
        if (!CheckFaceTarget())
        {
            SetAction(Rotate, Heal);
            return;
        }
        if (state != AIState.Heal)
        {
            state = AIState.Heal;
            DoAnimation(EntityAnimationName.Human_Heal);

            SetAction(Heal, null, actionTime);
        }
        else if (EndHeal())
        {
            if (CanDoAction())
            {
                GetTargetIHeal.Heal(actionValue);
                state = AIState.None;
            }
            else
                NextAction();
        }
    }

    /// <summary>
    /// working end Heal
    /// </summary>
    /// <param name="speed"></param>
    /// <returns></returns>
    /// 
    protected bool EndHeal()
    {
        return GetTargetIHeal == null || !GetTargetIHeal.isHealAble() || state_timer < Time.time;
    }



    #endregion
}

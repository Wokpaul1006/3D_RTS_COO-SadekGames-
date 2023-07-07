using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prey : Citizen
{
    #region Data
    Data_Prey data;

    protected override void LoadData()
    {
        base.LoadData();

        data = new Data_Prey(this);

        InitDataAI(data.foodDetectionRange * Vector3.one, data.walkSpeed, data.fleeSpeed, data.eatDuration);
        InitDataHunger(data.maxHunger, data.foodValue, data.hungerDecreaseRate);
        enemyTags = data.fleeTags;
    }

    #endregion

    #region normal condition
    protected override bool OnTarget(GameObject go)
    {
        return (state == AIState.MoveToTarget || state == AIState.Attack) && base.OnTarget(go);
    }
    #endregion

    #region Prey

    protected override IEnumerator Start()
    {
        yield return base.Start();
        AddDetection(data.enemyDetection, OnEnemyEnter, null, OnEnemyExit);

        Invoke("Hunger", 1f);
    }


    protected override void FindTarget()
    {
        if (target) return;
        List<GameObject> list = Utility.GetObjectAround(startPos, data.foodDetectionRange);
        foreach (GameObject go in list)
        {
            if (CanDoAction(go))
            {
                target = go;
                Active();
                MoveToTarget();
                break;
            }
        }
    }


    protected override bool AtTarget()
    {
        return isOnTarget || Vector3.SqrMagnitude(transform.position - GetTargetPos()) < moving_threshold;
    }




    protected override void NextAction()
    {
        if (state == AIState.Gather)
        {
            Idle();
        }
        else if (state == AIState.MoveToTarget)
        {
            if (CanDoAction())
            {
                Gather();
            }
            else Idle();
        }
        else base.NextAction();
    }


    protected override bool CanDoAction(GameObject go)
    {
        IGameObject iTag = go.GetComponent<IGameObject>();
        if (iTag == null) return false;
        return Utility.CheckHasTag(iTag.GetListTags(), data.foodTags) && base.CanDoAction(go);
    }

    protected override bool CanDoAction()
    {
        if (!target) return false;

        if (isOnTarget) return true;
        return state_timer < Time.time && TargetInRange();
    }

    #endregion

}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : BaseCharacterAI
{
    private Rigidbody body;

    #region Data
    Data_Soldier data;

    protected override void LoadData()
    {
        base.LoadData();
        data = new Data_Soldier(this);
        InitDataAI(new Vector3(data.patrolZX, data.patrolZY, data.patrolZZ), data.walkSpeed, data.runSpeed, data.attackSpeed, data.attackDamage, data.attackRange);
        idle_time = data.randomWalkFrequency;
    }
    #endregion

    #region normal condition
    protected override bool OnTarget(GameObject go)
    {
        return (state == AIState.RunToTarget || state == AIState.Attack) && base.OnTarget(go);
    }
    #endregion

    #region Soldier

    protected override IEnumerator Start()
    {
        yield return base.Start();

        if (data.tagList.Count > 0)
        {
            AddDetection(data.detectionRange, OnTargetEnter, null, OnTargetExit);
            StartCoroutine(CheckTarget());
        }
    }


    protected override bool IsTarget(IGameObject iGo)
    {

        return Utility.CheckHasTag(iGo.GetListTags(), data.tagList) && base.IsTarget(iGo);
    }

    protected override void NextAction()
    {
        if (state == AIState.RunToTarget || state == AIState.Attack)
        {
            if (CanDoAction())
            {
                Attack();
            }
            else
            {
                MoveToStartPos();
            }
            return;
        }

        base.NextAction();
    }

    protected override void RunToTarget()
    {
        if (CanDoAction(target)) base.RunToTarget();
        else MoveToStartPos();

    }


    public override void ActionAfterKill()
    {
        ListTarget.Remove(target.GetComponent<IGameObject>());

        base.ActionAfterKill();
    }

    protected override void ActionAfterHit()
    {
        if (data.autoDefense)
        {
            RunToTarget();
        }
        else
            base.ActionAfterHit();
    }

    #endregion

    #region Check Target

    IEnumerator CheckTarget()
    {
        while (true)
        {
            if (!target)
                foreach (IGameObject go in ListTarget)
                {
                    if (go.GetIHeal().isDead())
                    {
                        ListTarget.Remove(go);
                        break;
                    }

                    if (CanDoAction(go.GetOwner()))
                    {
                        target = go.GetOwner();
                        RunToTarget();
                        break;
                    }
                }
            yield return null;
        }
    }

    #endregion
}

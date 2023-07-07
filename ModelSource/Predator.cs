using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Predator : BaseCharacterAI
{
    #region Data
    BehaviourDataPredator data;


    protected override void LoadData()
    {
        base.LoadData();
        data = new BehaviourDataPredator(this);

        InitDataAI(new Vector3(data.chasingAX, transform.position.y, data.chasingAZ), data.walkSpeed, data.chaseSpeed, data.AttackSpeed, data.AttackDamage, data.attackRange);
        InitDataHunger(data.maxHunger, data.foodValue, data.hungerDecreaseRate);
    }


    #endregion

    #region normal condition
    protected override bool OnTarget(GameObject go)
    {
        return (state == AIState.RunToTarget || state == AIState.Attack) && base.OnTarget(go);
    }
    #endregion

    #region Predator

    protected override IEnumerator Start()
    {
        yield return base.Start();

        Invoke("Hunger", 1f);
    }


    protected override void FindTarget()
    {
        if (target) return;
        List<GameObject> list = Utility.GetObjectAround(startPos, data.detectionRange);
        foreach (GameObject go in list)
        {
            if (CanDoAction(go))
            {
                target = go;
                RunToTarget();
                break;
            }
        }
    }

    protected override void NextAction()
    {
        if (nextAction != null)
        {
            nextAction();
            return;
        }
        if (state == AIState.Idle)
        {
            Wander();
        }
        else if (state == AIState.Wander)
        {
            Idle();
        }
        else if (state == AIState.Run || state == AIState.Attack || state == AIState.Gather)
        {
            Idle();
        }
        else if (state == AIState.RunToTarget)
        {
            if (CanDoAction())
            {
                Attack();
            }
            else Idle();
        }
        else if (state == AIState.Hitting)
        {
            ActionAfterHit();
        }
    }

    protected override void RunToTarget()
    {
        if (CheckInZone(target))
            base.RunToTarget();
        else Idle();
    }

    public override void ActionAfterKill()
    {
        Gather();
    }


    protected override void ActionAfterHit()
    {
        if (target) RunToTarget();
        else base.ActionAfterHit();
    }


    protected override bool CanDoAction(GameObject go)
    {
        IGameObject iGo = go.GetComponent<IGameObject>();
        if (iGo == null || iGo.GetIHeal() == null || iGo.GetIHeal().isDead()) return false;
        return CheckInZone(go) && Utility.CheckHasTag(iGo.GetListTags(), data.tagList) && base.CanDoAction(go);
    }

    #endregion

}


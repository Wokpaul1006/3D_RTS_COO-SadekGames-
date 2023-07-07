using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : Citizen
{

    #region Data
    BehaviourDataFarmer data;

    protected override void LoadData()
    {
        base.LoadData();
        data = new BehaviourDataFarmer(this);

        InitDataAI(new Vector3(data.walkZX, data.walkZY, data.walkZZ), data.currentSpeed, data.fleeSpeed, data.gatheringSpeed);
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

    protected override bool CanDoAction(GameObject go)
    {
        //Plant plant = go.GetComponent<Plant>();
        //if (!plant) return false;
        IGameObject iGo = go.GetComponent<IGameObject>();
        return iGo != null && Utility.CheckHasTag(iGo.GetListTags(), data.gatherTags);
    }

    protected override bool OnTarget(GameObject go)
    {
        return (state == AIState.MoveToTarget || state == AIState.Gather) && base.OnTarget(go);
    }

    #endregion

    #region farmer

    protected override void NextAction()
    {
        if (state == AIState.Idle)
        {
            if (nextAction == null)
            {
                FindTarget();
                if (target)
                {
                    MoveToTarget();
                    return;
                }
            }
        }
        else if (state == AIState.MoveToTarget)
        {
            if (target)
            {
                Gather();
            }
            else Idle();

            return;

        }
        else if (state == AIState.Gather)
        {
            Idle();
            return;
        }
        base.NextAction();
    }
   

    protected override bool AtTarget()
    {
        return isOnTarget || Vector3.Magnitude(transform.position - GetTargetPos()) < moving_threshold + 1;
    }

    protected override void Eating()
    {
        
    }

    #endregion


}





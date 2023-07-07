using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class Citizen : BaseCharacterAI
{
    #region Data
    Data_Citizen data;

    protected List<string> enemyTags;

    protected override void LoadData()
    {
        base.LoadData();
        data = new Data_Citizen(this);
        InitDataAI(new Vector3(data.walkZX, data.walkZY, data.walkZZ), data.currentSpeed, data.fleeSpeed);
        enemyTags = data.fleeTags;
    }

    protected override IEnumerator Start()
    {
        yield return base.Start();

        if (CanFlee())
        {
            AddDetection(data.enemyDetection, OnEnemyEnter, null, OnEnemyExit);
        }
    }

    protected void OnEnemyExit(GameObject obj)
    {
        listEnemy.Remove(obj);

    }

    protected virtual void OnEnemyEnter(GameObject obj)
    {
        if (IsEnemy(obj, enemyTags))
        {
            listEnemy.Add(obj);
            target = obj;
            GoBack(Run);
        }
    }


    #endregion

    protected override void ActionAfterHit()
    {
        if (FleeToAttack())
        {
            GoBack(Run);
        }
        else base.ActionAfterHit();
    }


    #region normal condition
    protected virtual bool CanFlee()
    {
        return data.canFlee && data.fleeTags.Count > 0;
    }


    protected virtual bool FleeToAttack()
    {
        return data.fleeToAttack;
    }
    #endregion


}



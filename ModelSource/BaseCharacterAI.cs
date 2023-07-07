//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BaseCharacterAI : BaseBehaviour
//{
//    protected AIState state = AIState.None;

//    protected float actionTime, actionRange;// gather or heal, eat

//    //protected float detectEnemyRadius, detectRadius;

//    protected int actionValue;
//    protected bool interruptible, canBlockAttack, isAutoDefense = false;
//    protected float maxHunger, hungerDecreaseRate, foodValue, maxFood;
//    protected Vector3 moveZone = Vector3.zero, minZone = Vector3.zero, maxZone = Vector3.zero, startPos, targetPos;

//    protected Vector3 GetMinZone
//    {
//        get
//        {
//            if (minZone == Vector3.zero)
//            {
//                minZone = startPos;
//                minZone.x -= moveZone.x / 2;
//                minZone.z -= moveZone.z / 2;
//            }
//            return minZone;
//        }
//    }

//    protected Vector3 GetMaxZone
//    {
//        get
//        {
//            if (maxZone == Vector3.zero)
//            {
//                maxZone = startPos;
//                maxZone.x += moveZone.x / 2;
//                maxZone.z += moveZone.z / 2;
//            }
//            return maxZone;
//        }
//    }

//    protected GameObject target;

//    protected Rigidbody rb;

//    protected AnimController anim;

//    protected IHeal ownHeal;
//    protected IHeal GetIHeal
//    {
//        get
//        {
//            if (ownHeal == null)
//                ownHeal = GetComponent<IHeal>();
//            return ownHeal;
//        }
//    }

//    protected bool isDead
//    {
//        get
//        {
//            return GetIHeal != null && GetIHeal.isDead();
//        }
//    }

//    IHeal targetIheal;
//    protected IHeal GetTargetIHeal
//    {
//        get
//        {
//            if (target && targetIheal == null) targetIheal = target.GetComponent<IHeal>();
//            return targetIheal;
//        }

//        set
//        {
//            targetIheal = value;
//        }

//    }


//    /// <summary>
//    /// move
//    /// </summary>
//    protected float move_speed = 2, run_speed = 2;
//    protected Vector3 facing, move_target, move_target_avoid;
//    protected float avoid_side = 1f, avoid_angle = 0f;
//    protected float moving_threshold = 0.15f;
//    protected float rotate_speed = 8f;//
//    protected Vector3 start_pos;

//    protected float idle_time = 1.5f, action_time = 1.5f;
//    protected float state_timer;

//    protected bool isOnAir
//    {
//        get
//        {
//            Vector3 pos = transform.position;
//            pos.y += 0.5f;
//            if (Physics.SphereCast(pos, 0.08f, Vector3.down, out RaycastHit hit, 0.7f, 1 << LayerMask.NameToLayer("Ground")))
//            {
//                return false;
//            }

//            return true;
//        }
//    }

//    protected Action DoAction, nextAction;

//    protected List<GameObject> listCollider = new List<GameObject>();

//    protected List<GameObject> listEnemy = new List<GameObject>();
//    protected bool isOnTarget
//    {
//        get
//        {
//            return listCollider.Contains(target);
//        }
//    }

//    // Start is called before the first frame update
//    protected virtual IEnumerator Start()
//    {
//        InitComponent();
//        AddRigidBody();
//        startPos = transform.position;

//        RegisterHitting();

//        while (!PlayerComponent.myPlayer)
//            yield return null;

//        SetAction(Idle);

//        yield return null;
//    }

//    void InitComponent()
//    {
//        if (!rb) rb = GetComponent<Rigidbody>();
//        if (!anim) anim = GetComponent<AnimController>();
//    }

//    protected void InitDataAI(Vector3 moveZone, float move_speed, float run_speed, float actionSpeed = 1, int actionValue = 0, float actionRange = 1)
//    {
//        this.moveZone = moveZone;
//        this.move_speed = move_speed;
//        this.run_speed = run_speed;
//        if (actionSpeed > 0)
//            actionTime = 1 / actionSpeed;
//        else actionTime = 20f;
//        this.actionValue = actionValue;
//        this.actionRange = actionRange;
//    }

//    protected void InitDataAttack(bool interruptible, bool canBlockAttack)
//    {
//        this.interruptible = interruptible;

//        this.canBlockAttack = canBlockAttack;
//    }

//    protected void InitDataHunger(float maxHunger, float foodValue, float hungerDecreaseRate)
//    {
//        this.maxHunger = maxHunger;
//        maxFood = maxHunger;
//        this.foodValue = foodValue;
//        this.hungerDecreaseRate = hungerDecreaseRate;
//    }

    

//    private void AddRigidBody()
//    {
//        if (!rb) rb = gameObject.AddComponent<Rigidbody>();
//        Utility.SetBody(rb);
//    }
    
//    bool isActive = false;

//    protected void Active()
//    {
//        if (isActive) return;
//        isActive = true;
//        rb.useGravity = true;
//        rb.isKinematic = false;
//    }


//    protected void RegisterHitting()
//    {
//        if (TryGetComponent(out Health health))
//            health.registerOnHit(OnHit);
//    }

//    protected void OnHit(GameObject obj)
//    {
//        target = obj;
//        Hitting();
//    }

//    protected override void OnDestroy()
//    {

//        if (rb) Destroy(rb);

//        base.OnDestroy();

//        CancelInvoke();
//    }

//    private void OnCollisionEnter(Collision collision)
//    {
//        if (state == AIState.None) return;

//        listCollider.Add(collision.gameObject);

//    }

//    private void OnCollisionExit(Collision collision)
//    {
//        listCollider.Remove(collision.gameObject);
//    }


//    protected virtual bool OnTarget(GameObject go)
//    {
//        return listCollider.Contains(go);
//    }


//    /// <summary>
//    /// do action
//    /// </summary>
//    protected virtual void FixedUpdate()
//    {
//        if (isOnAir)
//        {

//            rb.velocity = Physics.gravity;
//            gameObject.layer = LayerMask.NameToLayer("IgnoreCollider");
//            if (isActive && rb.isKinematic) rb.isKinematic = false;
//            return;
//        }
//        else
//        {
//            Invoke("ActiveCollider", 1f);
//        }

//        if (!isDead)
//            DoAction?.Invoke();
//    }

//    void ActiveCollider()
//    {
//        gameObject.layer = unit.layer;
//    }

//    protected void Idle()
//    {
//        if (state != AIState.Idle)
//        {
//            resetTarget();
//            StopMoving();
//            state = AIState.Idle;

//            DoAnimation(EntityAnimationName.Human_Idle);
//            SetAction(Idle, null, idle_time);
//        }
//        else if (EndAction())
//        {
//            NextAction();
//        }

//    }

//    protected void StopMoving()
//    {
//        Vector3 velocity = Vector3.zero;
//        velocity.y = rb.velocity.y;
//        rb.velocity = velocity;
//        rb.angularVelocity = Vector3.zero;
//        rb.isKinematic = true;
//    }

//    protected void resetTarget()
//    {
//        target = null;
//        targetIheal = null;
//        targetPos = Vector3.zero;
//    }

//    protected void Rotate()
//    {
//        StopMoving();

//        if (isOnAir) return;

//        if (state != AIState.Rotate)
//        {
//            state = AIState.Rotate;
//            DoAnimation(EntityAnimationName.Human_Idle);
//        }
//        Vector3 targetDirection = (GetTargetPos() - transform.position).normalized;
//        targetDirection.y = 0;
//        if (targetDirection == Vector3.zero) return;
//        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
//        if (CheckFaceTarget())
//        {
//            rb.rotation = targetRotation;
//            NextAction();
//        }
//        else
//        {
//            Quaternion rotation = Quaternion.Slerp(rb.rotation, targetRotation, Time.deltaTime * rotate_speed);
//            transform.rotation = rotation;
//        }

//    }


//    protected void Wander()
//    {

//        if (!CheckFaceTarget())
//        {
//            SetAction(Rotate, Wander);
//            return;
//        }

//        if (state != AIState.Wander)
//        {
//            state = AIState.Wander;

//            DoAnimation(EntityAnimationName.Human_Walk);
//            Moving();
//            SetAction(Wander);
//        }
//        else if (AtTarget())
//        {
//            NextAction();
//        }
//        else
//            TryMoving();
//    }


//    protected void Run()
//    {
//        if (!CheckFaceTarget())
//        {
//            SetAction(Rotate, Run);
//            return;
//        }
//        if (state != AIState.Run)
//        {
//            state = AIState.Run;
//            DoAnimation(EntityAnimationName.Human_Run);
//            Running();
//            SetAction(Run);
//        }
//        else if (AtTarget())
//        {
//            if (listEnemy.Count > 0)
//            {
//                targetPos = Vector3.zero;
//            }
//            else NextAction();
//        }
//        else TryRunning();
//    }

//    protected void MoveToTarget()
//    {

//        if (!CheckFaceTarget())
//        {
//            SetAction(Rotate, MoveToTarget);
//            return;
//        }
//        if (state != AIState.MoveToTarget)
//        {
//            state = AIState.MoveToTarget;
//            DoAnimation(EntityAnimationName.Human_Walk);
//            SetAction(MoveToTarget);
//            Moving();
//        }
//        else if (AtTarget())
//        {
//            NextAction();
//        }
//        else
//        {
//            TryMoving();
//        }
//    }

//    protected void MoveToStartPos()
//    {
//        resetTarget();
//        if (transform.position == startPos)
//        {
//            Idle();
//            return;
//        }

//        startPos.y = transform.position.y;
//        targetPos = startPos;
//        Run();
//    }
//    protected virtual void RunToTarget()
//    {
//        if (!CheckFaceTarget())
//        {
//            SetAction(Rotate, RunToTarget);
//            return;
//        }

//        if (state != AIState.RunToTarget)
//        {
//            state = AIState.RunToTarget;
//            DoAnimation(EntityAnimationName.Human_Run);
//            SetAction(RunToTarget);
//            Running();
//        }
//        else if (CanDoAction())
//        {
//            NextAction();
//        }
//        else
//        {
//            TryRunning();
//        }
//    }

//    bool CheckCollider()
//    {
//        return Mathf.Abs(rb.velocity.x) < 0.2 && Mathf.Abs(rb.velocity.z) < 0.2f;
//    }

//    void TryMoving()
//    {
//        if (CheckCollider())
//        {
//            Idle();
//        }
//        else Moving();
//    }

//    protected virtual void Moving()
//    {
//        Active();
//        Vector3 speed = GetSpeed(move_speed);
//        rb.velocity = speed;
//        rb.isKinematic = false;
//    }
//    void TryRunning()
//    {
//        if (CheckCollider())
//        {
//            Idle();
//        }
//        else
//            Running();
//    }

//    protected virtual void Running()
//    {
//        Active();
//        Vector3 speed = GetSpeed(run_speed);
//        rb.velocity = speed;
//        rb.isKinematic = false;
//    }

//    protected bool CheckTargetAlive()
//    {
//        return GetTargetIHeal != null && !GetTargetIHeal.isDead();
//    }

//    protected virtual bool CheckInZone(GameObject target)
//    {
//        if (!target) return false;
//        Vector3 targetps = target.transform.position;
//        return targetps.x >= minZone.x && targetps.x <= maxZone.x && targetps.z >= minZone.z && targetps.z <= maxZone.z;
//    }

//    protected bool CheckFaceTarget()
//    {
//        Vector3 targetDirection = (GetTargetPos() - transform.position).normalized;
//        targetDirection.y = 0;
//        Vector3 direction = transform.forward;

//        return Mathf.Abs(direction.x - targetDirection.x) < 0.05f && Mathf.Abs(direction.z - targetDirection.z) < 0.05f;
//    }

//    #region Target Attack
//    protected List<IGameObject> ListTarget = new List<IGameObject>();//

//    protected virtual void OnTargetExit(GameObject obj)
//    {
//        ListTarget.Remove(obj.GetComponent<IGameObject>());
//    }

//    protected virtual void OnTargetEnter(GameObject go)
//    {
//        if (go.TryGetComponent(out IGameObject iGo) && !ListTarget.Contains(iGo) && IsTarget(iGo))
//        {
//            ListTarget.Add(iGo);
//        }
//    }

//    protected virtual bool IsTarget(IGameObject iGo)
//    {
//        if (iGo == null || iGo.GetIHeal() == null || iGo.GetIHeal().isDead()) return false;
//        return true;
//    }
//    #endregion

//    protected void Attack()
//    {
//        if (!EndAction()) return;
//        if (!CheckTargetAlive() || !CanDoAction(target))
//        {
//            SetAction(Idle);
//            //MoveToStartPos();
//            return;
//        }
//        if (!TargetInRange())
//        {
//            RunToTarget();
//            return;
//        }
//        if (!CheckFaceTarget())
//        {
//            SetAction(Rotate, Attack);
//            return;
//        }

//        if (state != AIState.Attack)
//        {
//            state = AIState.Attack;

//            DoAnimation(EntityAnimationName.Human_Attack);
//            Invoke("SpawnAttack", AttackTime());
//            SetAction(Attack, null, actionTime + AttackTime());
//        }
//        else
//        {
//            state = AIState.None;
//        }
//    }

//    public virtual void ActionAfterKill()
//    {
//        target = null;
//        NextAction();
//    }

//    protected void Hitting()
//    {
//        if (state != AIState.Hitting)
//        {
//            state = AIState.Hitting;
//            StopMoving();

//            DoAnimation(EntityAnimationName.Human_Hit);
//            SetAction(Hitting, null, HitTime());
//        }
//        else if (EndAction())
//        {
//            NextAction();
//        }
//    }

//    float AttackTime()
//    {
//        if (anim)
//        {
//            return anim.timeOfHit / 2f;
//        }
//        return 0.2f;
//    }

//    float HitTime()
//    {
//        if (anim)
//        {
//            return anim.timeOfHit;
//        }
//        return 0.5f;
//    }

//    void SpawnAttack()
//    {
//        DoAnimation(EntityAnimationName.Human_Idle);
//        if (interruptible && state == AIState.Hitting) return;
//        if (TargetInRange())
//            AttackMN.Instance.MeleeAttack(actionValue, gameObject, target.transform.position);
//    }

//    protected virtual bool TargetInRange()
//    {
//        if (!target) return false;
//        return listCollider.Contains(target) || Vector3.Distance(transform.position, target.transform.position) < actionRange;
//    }

//    protected virtual void Gather()
//    {
//        if (state != AIState.Gather)
//        {
//            state = AIState.Gather;
//            StopMoving();
//            DoAnimation(EntityAnimationName.Human_Gather);

//            SetAction(Gather, null, actionTime);
//        }
//        else if (EndAction())
//        {
//            UnitBlockFacade unit = target.GetComponent<UnitBlockFacade>();
//            if (unit)
//            {
//                unit.Hide();

//            }
//            Eating();

//            resetTarget();

//            NextAction();
//        }
//    }

//    protected virtual void Eating()
//    {
//        maxHunger += foodValue;
//        if (maxHunger >= maxFood)
//        {
//            maxHunger = maxFood;
//        }
//    }

//    protected void Hunger()
//    {
//        maxHunger -= hungerDecreaseRate;
//        if (maxHunger < 0)
//        {
//            maxHunger = 0;
//            FindTarget();
//        }

//        Invoke("Hunger", 1f);
//    }

//    /// <summary>
//    /// working
//    /// </summary>
//    protected virtual void NextAction()
//    {
//        if (nextAction != null)
//        {
//            nextAction();
//            return;
//        }
//        if (state == AIState.Idle)
//        {
//            Wander();
//        }
//        else if (state == AIState.Wander)
//        {
//            Idle();
//        }
//        else if (state == AIState.Run)
//        {
//            Idle();
//        }
//        else if (state == AIState.Hitting)
//        {
//            ActionAfterHit();
//        }
//    }

//    protected virtual void ActionAfterHit()
//    {
//        Idle();
//    }

//    protected void SetAction(Action currAction, Action nextAction = null, float actionTime = 0)
//    {
//        DoAction = currAction;
//        this.nextAction = nextAction;
//        SetStateTime(actionTime);
//    }

//    protected void SetStateTime(float actionTime)
//    {
//        state_timer = Time.time + actionTime;
//    }

//    protected bool EndAction()
//    {
//        return state_timer < Time.time;
//    }

//    protected virtual void FindTarget()
//    {
//        if (target) return;
//        List<GameObject> list = Utility.GetObjectAround(startPos, moveZone);
//        foreach (GameObject go in list)
//        {
//            if (CanDoAction(go))
//            {
//                target = go;
//                break;
//            }
//        }
//    }

//    protected virtual bool AtTarget()
//    {
//        return isOnTarget || Vector3.SqrMagnitude(transform.position - GetTargetPos()) < moving_threshold;
//    }
//    /// <summary>
//    /// check character can do action: attack, gather, heal
//    /// </summary>
//    /// <returns></returns>
//    protected virtual bool CanDoAction(GameObject go)
//    {
//        return Utility.CheckSeeObject(transform, go.transform);
//    }

//    /// <summary>
//    /// check character can do action: attack, gather, heal when already has target
//    /// </summary>
//    /// <returns></returns>
//    protected virtual bool CanDoAction()
//    {
//        if (!target || GetTargetIHeal.isDead()) return false;
//        if (!Utility.CheckSeeObject(transform, target.transform)) return false;
//        if (isOnTarget) return true;
//        return state_timer < Time.time && TargetInRange();
//    }

//    protected virtual bool IsEnemy(GameObject obj, List<string> enemyTags)
//    {
//        IGameObject iTag = obj.GetComponent<IGameObject>();

//        return iTag != null && Utility.CheckHasTag(iTag.GetListTags(), enemyTags);
//    }


//    /// <summary>
//    /// is escap
//    /// </summary>
//    /// <param name="nextAction"></param>
//    protected virtual void GoBack(Action nextAction)
//    {
//        if (!target)
//        {
//            Idle();
//            return;
//        }

//        targetPos = target.transform.position;
//        target = null;
//        Vector3 direction = (transform.position - targetPos).normalized;
//        SetRandomTarget(direction);
//        SetAction(nextAction);
//    }

//    protected float GetMaxDistance(float value, float min, float max)
//    {
//        if (value < min) return min;
//        if (value > max) return max;

//        return value;
//    }

//    protected Vector3 GetSpeed(float speed)
//    {
//        Vector3 direction = (GetTargetPos() - transform.position).normalized;
//        Vector3 sp = speed * direction;
//        sp.y = rb.velocity.y;

//        return speed * direction;
//    }

//    protected Vector3 GetTargetPos()
//    {
//        if (target) targetPos = target.transform.position;
//        else if (targetPos == Vector3.zero)
//        {
//            Vector3 positon = transform.position;
//            positon.x = UnityEngine.Random.Range(GetMinZone.x, GetMaxZone.x);
//            positon.z = UnityEngine.Random.Range(GetMinZone.z, GetMaxZone.z);
//            Vector3 direction = (positon - transform.position).normalized;
//            SetRandomTarget(direction);
//        }

//        return targetPos;
//    }

//    protected void SetRandomTarget(Vector3 direction)
//    {
//        targetPos = transform.position;
//        float startX = targetPos.x;

//        targetPos.x = startX + 100 * direction.x;
//        targetPos.x = GetMaxDistance(targetPos.x, GetMinZone.x, GetMaxZone.x);
//        float t = (targetPos.x - startX) / direction.x;

//        float startZ = targetPos.z;
//        targetPos.z = startZ + 100 * direction.z;
//        targetPos.z = GetMaxDistance(targetPos.z, GetMinZone.z, GetMaxZone.z);
//        float t2 = (targetPos.z - startZ) / direction.z;
//        if (Mathf.Abs(t) < Mathf.Abs(t2))
//            targetPos.z = startZ + t * direction.z;
//        else
//            targetPos.x = startX + t2 * direction.x;

//    }

//    protected void DoAnimation(EntityAnimationName animName)
//    {
//        if (!anim || isDead) return;
//        switch (animName)
//        {
//            case EntityAnimationName.Human_Idle:
//                anim.Idle();
//                break;
//            case EntityAnimationName.Human_Walk:
//                anim.Walk();
//                break;
//            case EntityAnimationName.Human_Run:
//                anim.Run();
//                break;
//            case EntityAnimationName.Human_Attack:
//                anim.Attack();
//                break;
//            case EntityAnimationName.Human_Death:
//                anim.Death();
//                break;
//            case EntityAnimationName.Human_Sitting:
//                break;
//            case EntityAnimationName.Human_Hit:
//                anim.Hit();
//                break;
//            case EntityAnimationName.Human_Gather:
//                anim.Gather();
//                break;
//            case EntityAnimationName.Human_Heal:
//                anim.Heal();
//                break;
//            case EntityAnimationName.Fly:
//                anim.Fly();
//                break;
//        }
//    }

//    public enum AIState
//    {
//        None,
//        Idle,
//        Rotate,
//        Wander,//walk
//        Run,
//        Flee,
//        MoveToTarget,
//        RunToTarget,
//        Attack,
//        Hitting,
//        Gather,
//        Heal,
//        Dead
//    }
//}


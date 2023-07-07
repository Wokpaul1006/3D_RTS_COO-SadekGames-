using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bird : BaseBehaviour
{
    private float range;
    private bool isIncrease, isDown;
    private Vector3 firstPos, forwardPos;
    float currentHeight, minHeight, maxHeight, angle;
    float plusSpd = 3f;

    #region Data
    BehaviourDataBird data;
    private AnimController anim;

    void Start()
    {
        behaviourType = BehaviourType.Bird;
        firstPos = transform.position;
        currentHeight = firstPos.y;

        if (data.minHeight == data.maxHeight)
        {
            minHeight = maxHeight = data.minHeight + currentHeight;
        }
        else
        {
            minHeight = currentHeight - data.minHeight;
            maxHeight = currentHeight + data.maxHeight;
        }
        anim = GetComponent<AnimController>();
        if (anim) anim.Fly();
    }
    protected override void LoadData()
    {
        base.LoadData();

        data = new BehaviourDataBird(this);
    }

    #endregion    

    void FixedUpdate()
    {
        UpdateForwardPos();
        UpdateHeight();
        UpdateForEntity();
        CaculateAngle();
        CaculateRange();
    }


    private void UpdateForwardPos()
    {
        float x = (Mathf.Cos(angle) * range) + firstPos.x;
        float z = (Mathf.Sin(angle) * range) + firstPos.z;
        forwardPos = new Vector3(x, currentHeight, z);

    }

    private void UpdateForEntity()
    {
        float x = (Mathf.Cos(angle - 1) * range) + firstPos.x;
        float z = (Mathf.Sin(angle - 1) * range) + firstPos.z;
        transform.position = new Vector3(x, currentHeight, z);
        transform.LookAt(forwardPos);
        transform.localEulerAngles = new Vector3(0f, transform.localEulerAngles.y, 30f);
    }

    private void UpdateHeight()
    {
        float delta = 0.2f;
        if (isDown)
        {
            delta = -0.2f;
        }

        currentHeight += (delta * Time.deltaTime * data.currentSpeed);

        if (currentHeight >= maxHeight)
        {
            isDown = true;
        }
        else if (currentHeight <= minHeight)
        {
            isDown = false;
        }

    }

    private void CaculateRange()
    {
        if (range <= data.currentMin) isIncrease = true;
        if (range >= data.currentMax) isIncrease = false;
        if (isIncrease) range += (Time.deltaTime * data.currentSpeed / 5f);
        else range -= (Time.deltaTime * data.currentSpeed / 5f);
        range = Mathf.Clamp(range, data.currentMin, data.currentMax);
    }

    private void CaculateAngle()
    {
        angle = angle + (plusSpd * Time.deltaTime * data.currentSpeed / range);
        if (angle >= 360) angle = 0;
    }
}


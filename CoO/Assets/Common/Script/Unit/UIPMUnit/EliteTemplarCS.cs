using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliteTemplarCS : BaseUnit
{
    //This unit is heavy infantry, play a role that advance anti surface, vulnerable to aircraft and artillery
    [SerializeField] Rigidbody body;
    private float TakenDmg;
    public GameObject target;

    BaseUnit unit = new BaseUnit();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

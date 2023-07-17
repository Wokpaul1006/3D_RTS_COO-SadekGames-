using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinCS : BaseUnit
{
    //This unit is Mediu Unit and play role that attack on infantry and armored, vulnerable with aircraft
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

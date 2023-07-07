using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : BaseBehaviour
{
    
    #region Data
    BehaviourDataPlant data;

    protected override void LoadData()
    {
        base.LoadData();
        data = new BehaviourDataPlant(this);
    }  

    #endregion
 
    public override void ReceiveMessage(string message)
    {
        if (data.listMessageDestroy.Contains(message))
        {
            unit.Hide();
        }
    }
}

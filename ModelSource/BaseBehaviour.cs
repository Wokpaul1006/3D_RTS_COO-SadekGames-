//using Newtonsoft.Json;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//[System.Serializable]
//public class BaseBehaviour : BaseFeature
//{    
//    public string behaviourName;
//    [HideInInspector]
//    public BehaviourType behaviourType;
   
//    public void SetData(UnitBlockFacade unit)
//    {
//        this.unit = unit;
//        jsData = unit.behaviourData;
//        if (jsData.IsNull)
//        {
//            InitData();
//            UpdateData();
//        }
//        else
//            LoadData();

//        AddEvent();

//        UpdateUI();

//        LoadListData();
//    }   

//    /// <summary>
//    /// Load data from server
//    /// </summary>
//    protected override void LoadData()
//    {
//        int type = 0;
//        GetIValue(ref type, Schema.type);
//        behaviourType = (BehaviourType)type;
//    }

//    /// <summary>
//    /// Init Data for behaviour
//    /// </summary>
//    protected override void InitData()
//    {
//        jsData = new JSONObject();
//        unit.behaviourData = jsData;
//    }   
    
//    /// <summary>
//    /// update data of object
//    /// </summary>
//    protected override void UpdateData()
//    {
//        unit.behaviourData.SetField(Schema.type, (int)behaviourType);
//    }

//}

//public class BaseData
//{
//    public List<string> listMessageRequired = new List<string>() { "Interact" };

//    public List<string> tagList = new List<string>() { "Player" };



//}

//public enum BehaviourType
//{
//    None, Dev_Only, Animated_Decoration, Asker, Asset_Spawner, Basic_Platform, Bird, Button, Citizen, Door, Farmer, Healer, Melee_Enemy, Message_Broadcaster,
//    Multi, Plant, Predator, Prey, Replace_Asset, Soldier, Void
//}

//public enum State
//{
//    Idle,
//    Run,
//    Walk,
//    Attack,
//    Flee,
//    Gather,
//    Heal
//}

//public enum Activation
//{
//    OnStart,
//    OnReceiveMessage,
//}

//public enum Destruction
//{
//    DontDestroy,
//    DestroyAllExceptFromList,
//    OnlyDestroyFromList,
//}

//public enum ReplaceCollision
//{
//    NoCollisions,
//    Collisions,
//    CollisionsAndGravity,
//}

//public enum OpeningMode
//{
//    PlayAnimation,
//    RotateAroundPivot
//}

//public enum BroadcastType
//{
//    EveryoneInRange,
//    SpecificTagsInRange,
//    SelectedActors,
//    All
//}

//public enum DoorStartingState
//{
//    CloseDoor,
//    OpenDoor
//}

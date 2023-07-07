//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public abstract class BaseFeature : BaseMono
//{
//    [HideInInspector]
//    public UnitBlockFacade unit;

//    [SerializeField] protected List<GameObject> editModeUI;

//    protected JSONObject jsData = new JSONObject();

//    protected abstract void LoadData();

//    /// <summary>
//    /// Init Data for behaviour
//    /// </summary>
//    protected abstract void InitData();


//    protected abstract void UpdateData();
//    #region Get data
//    public void GetIValue(ref int var, Schema s)
//    {
//        jsData.GetField(ref var, s);
//    }

//    public void GetFValue(ref float var, Schema s)
//    {
//        jsData.GetField(ref var, s);
//    }

//    public void GetBValue(ref bool var, Schema s)
//    {
//        jsData.GetField(ref var, s);
//    }

//    public void GetSValue(ref string var, Schema s)
//    {
//        jsData.GetField(ref var, s);
//    }

//    public void GetListSValue(ref List<string> var, Schema s)
//    {
//        JSONObject list = jsData.GetField(s);
//        if (list == null) return;
//        var = new List<string>();
//        if (!list.IsNull)
//        {
//            foreach (JSONObject item in list.list)
//            {
//                var.Add(item.str);
//            }
//        }
//    }
//    public void GetListIValue(ref List<int> var, Schema s)
//    {
//        JSONObject list = jsData.GetField(s);
//        if (list == null) return;
//        var = new List<int>();

//        if (!list.IsNull)
//        {
//            foreach (JSONObject item in list.list)
//            {
//                var.Add(((int)item.f));
//            }
//        }
//    }


//    #endregion

//    #region Set Data
//    protected void SetIValue(Schema s, int value)
//    {
//        jsData.SetField(s, value);
//    }

//    protected void SetFValue(Schema s, float value)
//    {
//        jsData.SetField(s, value);
//    }

//    protected void SetBValue(Schema s, bool value)
//    {
//        jsData.SetField(s, value);
//    }

//    protected void SetSValue(Schema s, string value)
//    {
//        jsData.SetField(s, value);
//    }

//    public void SetListSValue(Schema s, List<string> listValue)
//    {
//        JSONObject list = new JSONObject();
//        foreach (string value in listValue)
//            list.Add(value);

//        jsData.SetField(s, list);
//    }
//    protected void SetListIValue(Schema s, List<int> listValue)
//    {
//        JSONObject list = new JSONObject();
//        foreach (int value in listValue)
//            list.Add(value);

//        jsData.SetField(s, list);
//    }

//    #endregion
 

//    internal void ShowEditMode(bool show)
//    {
//        foreach (var item in editModeUI)
//        {
//            item.SetActive(show);
//        }
//        onClickEditlogic(show);
//    }
//    /// <summary>
//    /// init ui and set event for ui
//    /// </summary>
//    protected virtual void AddEvent() { }
//    /// <summary>
//    /// show or hide other option
//    /// </summary>
//    protected virtual void UpdateUI() { }
//    /// <summary>
//    /// load list data: list mess, list tag...
//    /// </summary>
//    protected virtual void LoadListData() { }

//    public virtual void onClickEditlogic(bool value)
//    {

//    }
//    public virtual void SetBehaviourType(BehaviourType behaviourType)
//    {

//    }

//    public virtual void SetComponentType(ComponentType componentType)
//    {

//    }

//    public virtual void ReceiveMessage(string message)
//    {

//    }

//    public virtual void PlayerInteract()
//    {
//        ReceiveMessage(MESSAGE.Interact.ToString());
//    }
//    protected InteractionMN interact;
//    protected InteractionMN AddInteraction()
//    {
//        interact = Instantiate(BehaviorMN.Instance.preInteract, transform);
//        interact.InitValue(unit);

//        return interact; 
//    }

//    List<Detection> listDetection = new List<Detection>();
//    protected void AddDetection(float range, Action<GameObject> OnEnter, Action<GameObject> OnStay, Action<GameObject> OnExit)
//    {
//        Detection detection = Instantiate(BehaviorMN.Instance.preDetection, transform);
//        detection.setRange(range / transform.localScale.x);
//        detection.Register(gameObject, OnEnter, OnExit, OnStay);

//        listDetection.Add(detection);
//    }

//    protected override void OnDestroy()
//    {
//        if (interact) Destroy(interact.gameObject);

//        foreach (Detection detection in listDetection)
//        {
//            Destroy(detection.gameObject);
//        }

//        listDetection.Clear();

//        base.OnDestroy();
//    }
//}

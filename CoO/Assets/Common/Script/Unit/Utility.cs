//using Newtonsoft.Json;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class Utility
//{
//    public static void SetValueSlider(Slider sl, float value)
//    {
//        if (sl.value == value) return;
//        sl.value = value;
//    }

//    public static void SetValueToggle(Toggle tg, bool value)
//    {
//        if (tg.isOn == value) return;
//        tg.isOn = value;
//    }

//    public static void SetValueSlider(Slider sl, float value, int round = 0)
//    {
//        value = RoundTo(value, round);

//        if (sl.value == value) return;
//        sl.value = value;
//    }

//    public static void SetValueInput(InputField input, string value)
//    {
//        if (input.text == value) return;
//        input.text = value;
//    }

//    public static bool isValueInput(InputField input, float min, float max)
//    {
//        if (input.contentType != InputField.ContentType.IntegerNumber && input.contentType != InputField.ContentType.DecimalNumber) return true;

//        float fvalue = FParse(input.text);
//        if (fvalue <= max && fvalue >= min) return true;

//        fvalue = Mathf.Clamp(fvalue, min, max);
//        input.text = fvalue.ToString();

//        return false;
//    }

//    internal static bool CollidePlayer(List<string> tags, string tag)
//    {
//        return tags.Contains("Player") && tag == "FaceCol";
//    }

//    public static void SetTextValueButton(Button btn, string text)
//    {
//        Text txt = btn.GetComponentInChildren<Text>();
//        if (txt)
//            txt.text = text;
//    }

//    public static void SetValueInput(InputField input, float value, int round = 0)
//    {
//        value = RoundTo(value, round);
//        string svalue = value.ToString();
//        if (input.text == svalue) return;
//        input.text = svalue;
//    }

//    internal static DateTime LocalTimeFromTimeStamp(int timeStamp)
//    {
//        DateTime time = new DateTime(1970, 1, 1);
//        time = time.AddSeconds(timeStamp);

//        return time.ToLocalTime();
//    }

//    internal static string TimeSpanFormat(TimeSpan time)
//    {
//        return time.ToString(@"mm\:ss");
//    }

//    public static void SetValueInput(InputField input, string value, int round)
//    {
//        float fvalue = FParse(value);
//        fvalue = RoundTo(fvalue, round);
//        value = fvalue.ToString();
//        if (input.text == value) return;
//        input.text = value;
//    }

//    internal static IGameObject GetIGame(GameObject go)
//    {
//        return go.GetComponent<IGameObject>();
//    }

//    internal static bool IsPlayer(GameObject go)
//    {
//        PlayerComponent target = go.GetComponent<PlayerComponent>();
//        return target;
//    }

//    internal static bool IsMyPlayer(GameObject go)
//    {
//        if (!go) return false;

//        PlayerComponent target = go.GetComponent<PlayerComponent>();
//        return target && target.IsMine;
//    }

//    internal static PlayerComponent  GetMyPlayer(GameObject go)
//    {
//        PlayerComponent player = go.GetComponent<PlayerComponent>();
//        if (!player) player = go.GetComponentInParent<PlayerComponent>();
//        if (player && player.IsMine) return player;

//        return null;
//    }

//    internal static bool CheckSeeObject(Transform trans, Transform target)
//    {
//        RaycastHit hit;
//        Vector3 origin = trans.position;
//        origin.y += 0.4f;
//        Vector3 targetPos = target.position;
//        targetPos.y += 0.4f;
//        Vector3 direction = (targetPos - origin).normalized;
//        origin = origin + direction;

//        if(Physics.Raycast(origin, direction, out hit))
//        {
//            IGameObject itag = hit.collider.GetComponent<IGameObject>();
//            if (itag == null) itag = hit.collider.GetComponentInParent<IGameObject>();
//            return itag != null && itag.GetOwner() == target.gameObject;

//        }

//        return false;
//    }

//    public static void SetValueDropdown(Dropdown drop, int value)
//    {
//        if (drop.value == value) return;
//        drop.value = value;
//    }

//    public static void SetValueDropdown(Dropdown drop, string value)
//    {
//        if (drop.captionText.text == value) return;
//        for(int i = 0; i < drop.options.Count; i++)
//        {
//            if (drop.options[i].text == value) drop.value = i; 
//        }
//    }


//    public static void SetValueDropdownMessageFromString(Dropdown drop, string value)
//    {
//        for (int i = 0; i < ModelMN.currentDataMap.GetMessage().Count; i++)
//        {
//            if (ModelMN.currentDataMap.GetMessage(i) == value)
//            {
//                drop.value = i;
//                break;
//            }
//        }
//    }

//    //public static void SetValueList(List<string> listString, string value)
//    //{
//    //    if (listString.ToString() == value) return;
//    //    listString.ToString() = value;
//    //}

//    public static void SetValueText(Text text, string value)
//    {
//        if (text.text == value) return;
//        text.text = value;
//    }

//    internal static void SetBody(Rigidbody rb)
//    {
//        rb.useGravity = false;
//        rb.isKinematic = true;
//        rb.mass = 50f;
//        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
//    }

//    public static float RoundTo(float value, int number)
//    {
//        value = (float)Math.Round(value, number);
//        return value;
//    }

//    public static float FParse(string value)
//    {
//        float fvalue = 0;

//        float.TryParse(value, out fvalue);

//        return fvalue;
//    }

//    public static int IParse(string value)
//    {
//        int ivalue = 0;

//        int.TryParse(value, out ivalue);

//        return ivalue;
//    }

//    public static string RandomID()
//    {
//        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
//        var stringChars = new char[8];
//        var random = new System.Random();

//        for (int i = 0; i < stringChars.Length; i++)
//        {
//            stringChars[i] = chars[random.Next(chars.Length)];
//        }
//        var finalString = new String(stringChars);

//        return finalString;
//    }

//    static bool isFreezeControl;
//    public static void isFreezeControlSetting(bool isFreeze)
//    {
//        isFreezeControl = isFreeze;
//    }

//    public static bool isAttacking()
//    {
//        if (isFreezeControl) return false;
//        return Input.GetButton("Fire1");
//    }

//    public static float HorizontalMoving()
//    {
//        if (isFreezeControl) return 0f;
//        return Input.GetAxis("Horizontal");
//    }

//    public static float VerticalMoving()
//    {
//        if (isFreezeControl) return 0f;
//        return Input.GetAxis("Vertical");
//    }

//    public static bool isJumping()
//    {
//        if (isFreezeControl) return false;
//        return Input.GetButton("Jump");
//    }

//    public static float HorizontalMouse()
//    {
//        if (isFreezeControl) return 0f;
//        return Input.GetAxis("Horizontal");
//    }

//    public static float VerticalMouse()
//    {
//        if (isFreezeControl) return 0f;
//        return Input.GetAxis("Vertical");
//    }

//    public static float ScrollWheelMouse()
//    {
//        if (isFreezeControl) return 0f;
//        return Input.GetAxis("Mouse ScrollWheel");
//    }
//    public static float GetXMouse()
//    {
//        if (isFreezeControl) return 0f;
//        return Input.GetAxis("Mouse X");
//    }
//    public static float GetYMouse()
//    {
//        if (isFreezeControl) return 0f;
//        return Input.GetAxis("Mouse Y");
//    }

//    public static bool isSpaceClick()
//    {
//        return Input.GetKey(KeyCode.Space);
//    }

//    public static bool isShiftClick()
//    {
//        return Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
//    }

//    public static bool isShiftUp()
//    {
//        return Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift);
//    }

//    public static float GetDuplicateDistance(UnitBlockFacade unit)
//    {
//        if (unit == null) return 0f;
//        Vector3 scale = unit.gameObject.transform.localScale;
//        BoxCollider col = unit.gameObject.GetComponent<BoxCollider>();
//        if (col == null) return 0f;
//        var min = col.center - col.size * 0.5f;
//        var max = col.center + col.size * 0.5f;
//        float x = Mathf.Abs(max.x - min.x) * scale.x;
//        return x;
//    }

//    public static bool isCorrectString(List<string> list1, List<string> list2)
//    {
//        foreach (string str in list1)
//            if (list2.Contains(str)) return true;

//        return false;
//    }

//    public static bool isCorrectString(List<string> list1, string id)
//    {
//        for (int i = 0; i < list1.Count; i++)
//        {
//            if (list1[i] == id) return true;
//        }
//        return false;
//    }

//    public static List<GameObject> GetObjectAround(Vector3 position, float radius)
//    {
//        Collider[] colliders = Physics.OverlapSphere(position, radius);

//        List<GameObject> list = new List<GameObject>();
//        foreach(Collider collider in colliders)
//        {
//            if (collider.gameObject.activeInHierarchy && !list.Contains(collider.gameObject)) list.Add(collider.gameObject);
//        }

//        return list;
//    }

//    public static List<GameObject> GetObjectAround(Vector3 position, Vector3 box)
//    {
//        Collider[] colliders = Physics.OverlapBox(position, new Vector3(box.x / 2f, box.y / 2, box.z / 2));

//        List<GameObject> list = new List<GameObject>();
//        foreach (Collider collider in colliders)
//        {
//            if (!list.Contains(collider.gameObject)) list.Add(collider.gameObject);
//        }

//        return list;
    
//    }   

//    public static bool CheckHasTag(List<string> listTag, List<string> listTargetTag)
//    {
//        foreach(string tag in listTargetTag)
//        {
//            if (listTag.Contains(tag)) return true;
//        }

//        return false;
//    }
       
//}

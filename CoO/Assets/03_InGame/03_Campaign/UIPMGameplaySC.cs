using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPMGameplaySC : MonoBehaviour
{
    [SerializeField] GameObject marine;
    public void SpawnUnit()
    {
        Instantiate(marine, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void SpawnStruct()
    {

    }
}

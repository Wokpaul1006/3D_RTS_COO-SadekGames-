using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComCenSC : MonoBehaviour
{
    [SerializeField] GameObject marine;
    
    public void SpawnMarine()
    {
        Instantiate(marine);
    }
}

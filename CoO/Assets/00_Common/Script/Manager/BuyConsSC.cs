using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyConsSC : MonoBehaviour
{
    public GameObject Cons;
    // Start is called before the first frame update

    // Update is called once per frame

    public void OnInitCons()
    {
        Instantiate(Cons, new Vector3(0, 0, 0), Quaternion.identity);
    }
}

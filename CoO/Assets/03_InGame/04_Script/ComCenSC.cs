using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComCenSC : MonoBehaviour
{
    [SerializeField] GameObject marine;
    [SerializeField] GameObject powePlant;
    [SerializeField] GameObject botPanel;
    [SerializeField] Vector3 comcenPos;

    int clickCount;
    void Start()
    {
        botPanel = GameObject.Find("PNL_BotZone");
        clickCount = 0;
        comcenPos = transform.position;
    }

    private void OnMouseDown()
    {
        if (clickCount == 0 || clickCount == 1) 
        {
            botPanel.SetActive(true);
            clickCount++;
        }else if(clickCount == 2) 
        {
            botPanel.SetActive(false);
            clickCount = 1;
        }
    }

    public void BuildPlant()
    {
        Instantiate(powePlant, new Vector3(comcenPos.x + 2f, 1, comcenPos.z + 2), Quaternion.identity); //Spawn ComCen
    }

    public void BuildMarine()
    {
        Instantiate(marine, new Vector3(comcenPos.x - 2f, 1, comcenPos.z - 2), Quaternion.identity);
    }
}

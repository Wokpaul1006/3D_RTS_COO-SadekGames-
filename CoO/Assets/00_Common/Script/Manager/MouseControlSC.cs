using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;   
        mousePos.z=Camera.main.nearClipPlane;
        Vector3 Worldpos=Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 Worldpos2D = new Vector2(Worldpos.x, Worldpos.y);
        //Worldpos2D is required if you are making a 2D game 
       
    }
}
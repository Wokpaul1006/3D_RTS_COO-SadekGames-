using UnityEngine;
using System.Collections;

public class CameraController: MonoBehaviour
{
    public float moveSpeed;
    public float zoomSpeed;
    public float minZoomDist;
    public float maxZoomDist;
    private Camera cam;
    // Use this for initialization

    public void Awake()
    {
        cam = Camera.main;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

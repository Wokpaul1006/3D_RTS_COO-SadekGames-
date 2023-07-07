using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMN : MonoBehaviour
{
    [Header("Objcet Definition")]
    [SerializeField] GameObject plane;
    [SerializeField] GameObject commandBuilding;
    [SerializeField] GameObject cam;
    [SerializeField] Transform parent;

    [Header("Variables")]
    private int _mapSize;
    private float _mapPosX, _mapPosZ;

    private void Start()
    {
        OnStartGame();
    }
    private void OnStartGame() 
    {
        _mapSize = 12;
        SpawnMap();
        SpawnStructure();
    }

    private void SpawnMap()
    {
        _mapPosZ = 0;
        for(int i = 0; i < _mapSize/3; i++)
        {
            SpawnMapHorizontal(_mapPosZ);
            _mapPosZ += 10;
        }
    }
    private void SpawnMapHorizontal(float z)
    {
        _mapPosX = 0;
        for(int i = 0; i < _mapSize/3; i++) 
        {
            Instantiate(plane,new Vector3(_mapPosX, 0, z), Quaternion.identity);
            _mapPosX += 10f;
        }
    }
    private void SpawnStructure()
    {
        Instantiate(commandBuilding, new Vector3(0, 0, 0), Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMN : MonoBehaviour
{
    private InGameMN instace;

    [Header("Objcet Definition")]
    [SerializeField] GameObject plane;
    [SerializeField] GameObject commandBuilding;
    [SerializeField] GameObject cam;
    [SerializeField] Transform parent;

    [SerializeField] PlayerDataSC playerDataSC;

    [Header("Variables")]
    private int _faction;
    private int _foeID;
    private string _callSource;
    private int _mapSize;
    private float _mapPosX, _mapPosZ;

    public void GetInfoForBattle()
    {
        _faction = playerDataSC.GetSkirmishPlayerFaction();
        _foeID = playerDataSC.GetSkirmishFoeID() ;
        _mapSize = playerDataSC.GetSkirmishMapSize();
    }

    private void Start()
    {
        OnStartGame();
    }
    private void OnStartGame() 
    {
        GetInfoForBattle();
        SpawnMap();
        SpawnStructure();
        CameraPointToComCen();

        ///playerDataSC = GameObject.Find("PlayerDataMN").GetComponent<PlayerDataSC>();
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

    private void CameraPointToComCen()
    {
        cam.transform.position = commandBuilding.transform.position;
    }
}

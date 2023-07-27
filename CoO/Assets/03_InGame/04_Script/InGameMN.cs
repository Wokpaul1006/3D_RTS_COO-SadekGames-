using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMN : MonoBehaviour
{
    private InGameMN instace;

    [Header("Objcet Definition")]
    [SerializeField] GameObject plane;
    [SerializeField] List<GameObject> commandBuilding = new List<GameObject>();
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
        playerDataSC = GameObject.Find("PlayerDataMN").GetComponent<PlayerDataSC>();

        OnStartGame();
    }
    private void OnStartGame() 
    {
        GetInfoForBattle();
        SpawnMap();
        SpawnCommandStructure(_faction);
    }

    private void SpawnMap()
    {
        _mapPosZ = 0;
        for(int i = 0; i < _mapSize/3; i++)
        {
            SpawnMapHorizontal(_mapPosZ);
            _mapPosZ -= 10;
        }
    }
    private void SpawnMapHorizontal(float z)
    {
        _mapPosX = 0;
        for(int i = 0; i < _mapSize/3; i++) 
        {
            Instantiate(plane,new Vector3(_mapPosX, 0, z), Quaternion.identity);
            _mapPosX -= 10f;
        }
    }
    private void SpawnCommandStructure(int factionID)
    {
        switch (factionID) 
        {
            case 0:
                Instantiate(commandBuilding[0], new Vector3(0, 1, 0), Quaternion.identity); //Spawn ComCen
                break;
            case 1:
                Instantiate(commandBuilding[1], new Vector3(0, 1, 0), Quaternion.identity); //Spawm Hivemind
                break;
            case 2:
                Instantiate(commandBuilding[2], new Vector3(0, 1, 0), Quaternion.identity); //Spaw Shogunate
                break;
        }
    }
}

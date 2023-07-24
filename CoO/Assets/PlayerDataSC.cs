using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataSC : Singleton<PlayerDataSC>
{
    [Header("Skirmish Vars")]
    public int factionToPlay;
    public int factionToFoe;
    public int mapSize;
    public void SetSkirmishData(int _playerFaction, int _foeFaction, int _mapSize)
    {
        factionToPlay = _playerFaction;
        factionToFoe = _foeFaction;
        mapSize = _mapSize;
    }
    public int GetSkirmishPlayerFaction()
    {
        return factionToPlay;
    }
    public int GetSkirmishMapSize() 
    {
        return mapSize;
    }
    public int GetSkirmishFoeID()
    {
        return factionToFoe;
    }
}

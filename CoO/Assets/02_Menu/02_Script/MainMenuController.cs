using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [Header("Main Objects")]
    [SerializeField] GameObject mainPnl;
    [SerializeField] GameObject campaignPnl;
    [SerializeField] GameObject infoPnl;
    [SerializeField] GameObject skirmishPnl;

    [Header("Info's Objects")]
    [SerializeField] UnitInfoSC unitInfo;
    [SerializeField] GameObject infoUIPMPnl;
    [SerializeField] GameObject infoLoVTPnl;
    [SerializeField] GameObject infoNEAPnl;

    [SerializeField] PlayerDataSC ingameSC;

    [SerializeField] List<Sprite> spriteUIPM = new List<Sprite>();
    [SerializeField] List<Sprite> spriteLoVT= new List<Sprite>();
    [SerializeField] List<Sprite> spriteNEA = new List<Sprite>();

    [SerializeField] Text unitNameTxt;
    [SerializeField] Text unitDesTxt;
    [SerializeField] Text realTimeTxt;
    [SerializeField] Dropdown factionDrop;
    [SerializeField] Image unitImg;

    [Header("Skirimsh's Objects")]
    [SerializeField] Dropdown mapSizeDrop;

    [Header("Variables")]
    private int unitIDChoose;       //Information panel element
    private int unitFaction;        //Information panel element
    private int unitSpriteIndex;    //Information panel element

    private int campFactionID;      //Campaign panel element

    private int skirmishFoeFactionID;       //Skirmish panel element
    private int skirmishPlayerFactionID;    //Skirmish panel element
    private int mapID;  //Skirmish panel element
    private int mapSize;    //Skirmish panel element

    [HideInInspector]
    DateTime now =  DateTime.Now;

    private void Start()
    {
        SettingStart();
    }

    private void Update()
    {
        GetRealTime();
    }

    private void SettingStart()
    {
        if(!mainPnl.activeSelf) 
        {
            mainPnl.SetActive(true);
        }
        unitIDChoose = 0;
        campFactionID = 0;

        ingameSC = GameObject.Find("PlayerDataMN").GetComponent<PlayerDataSC>();
    }

    #region Info Panel function
    public void SelectInfo()
    {
        switch (factionDrop.value) 
        {
            case 0:
                infoUIPMPnl.SetActive(true);
                infoLoVTPnl.SetActive(false);
                infoNEAPnl.SetActive(false);
                break;
            case 1:
                infoUIPMPnl.SetActive(false);
                infoLoVTPnl.SetActive(true);
                infoNEAPnl.SetActive(false);
                break;
            case 2:
                infoUIPMPnl.SetActive(false);
                infoLoVTPnl.SetActive(false);
                infoNEAPnl.SetActive(true);
                break;
        }
    }
    public void ShowUnitInfo()
    {
        unitNameTxt.text = unitInfo.GetUnitName(unitIDChoose, unitFaction);
        unitDesTxt.text = unitInfo.GetUnitDes(unitIDChoose, unitFaction);
    }
    public void OnChangeSprite(int factionID, int UnitID)
    {
        if(factionID == 1)
        {
            unitSpriteIndex = UnitID;
            unitImg.GetComponent<Image>().sprite = spriteUIPM[unitSpriteIndex];
        }else if(factionID == 2)
        {
            unitSpriteIndex = UnitID;
            unitImg.GetComponent<Image>().sprite = spriteLoVT[unitSpriteIndex];
        }
        else if(factionID == 3)
        {
            unitSpriteIndex = UnitID;
            unitImg.GetComponent<Image>().sprite = spriteNEA[unitSpriteIndex];
        }
    }
    #endregion

    #region Callback for UIPM
    public void OnMarine()
    {
        unitFaction = 1;
        unitIDChoose = 1;
        ShowUnitInfo(); 
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnRocket() 
    {
        unitFaction = 1;
        unitIDChoose = 2;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnEngineer() 
    {
        unitFaction = 1;
        unitIDChoose = 3;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnPaladins() 
    {
        unitFaction = 1;
        unitIDChoose = 4;
        ShowUnitInfo(); 
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnGhost() 
    {
        unitFaction = 1;
        unitIDChoose = 5;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnTemplar ()
    {
        unitFaction = 1;
        unitIDChoose = 6;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnTroncycles()
    {
        unitFaction = 1;
        unitIDChoose = 7;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnSpider()
    {
        unitFaction = 1;
        unitIDChoose = 8;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnTauros()
    {
        unitFaction = 1;
        unitIDChoose = 9;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnAmageddon()
    {
        unitFaction = 1;
        unitIDChoose = 10;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnQuadammo()
    {
        unitFaction = 1;
        unitIDChoose = 11;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnSkyhammer()
    {
        unitFaction = 1;
        unitIDChoose = 12;
        ShowUnitInfo(); 
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnSkylynx()
    {
        unitFaction = 1;
        unitIDChoose = 13;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnCondor()
    {
        unitFaction = 1;
        unitIDChoose = 14;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnAC130()
    {
        unitFaction = 1;
        unitIDChoose = 15;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnYamato()
    {
        unitFaction = 1;
        unitIDChoose = 16;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnTransport()
    {
        unitFaction = 1;
        unitIDChoose = 17;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnYeager()
    {
        unitFaction = 1;
        unitIDChoose = 18;
        ShowUnitInfo();  
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    #endregion

    #region Callback for LoVT
    public void OnBrutes()
    {
        unitFaction = 2;
        unitIDChoose = 1;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnTrolls()
    {
        unitFaction = 2;
        unitIDChoose = 2;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnParasite()
    {
        unitFaction = 2;
        unitIDChoose = 3;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnNazgull()
    {
        unitFaction = 2;
        unitIDChoose = 4;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnFacelesss()
    {
        unitFaction = 2;
        unitIDChoose = 5;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnWarlocks()
    {
        unitFaction = 2;
        unitIDChoose = 6;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnCreepling()
    {
        unitFaction = 2;
        unitIDChoose = 7;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnYeti()
    {
        unitFaction = 2;
        unitIDChoose = 8;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnArachilings()
    {
        unitFaction = 2;
        unitIDChoose = 9;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnMegarhinox()
    {
        unitFaction = 2;
        unitIDChoose = 10;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnDinoflak()
    {
        unitFaction = 2;
        unitIDChoose = 11;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnOctapods()
    {
        unitFaction = 2;
        unitIDChoose = 12;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnApes()
    {
        unitFaction = 2;
        unitIDChoose = 13;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnZalak()
    {
        unitFaction = 2;
        unitIDChoose = 14;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnCanonest()
    {
        unitFaction = 2;
        unitIDChoose = 15;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnMutalisk()
    {
        unitFaction = 2;
        unitIDChoose = 16;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnGiga()
    {
        unitFaction = 2;
        unitIDChoose = 17;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnSerpent()
    {
        unitFaction = 2;
        unitIDChoose = 18;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    #endregion

    #region Callback for NEA
    public void OnWarriors()
    {
        unitFaction = 3;
        unitIDChoose = 1;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnFlyfisher()
    {
        unitFaction = 3;
        unitIDChoose = 2;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnProbes()
    {
        unitFaction = 3;
        unitIDChoose = 3;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnIronborn()
    {
        unitFaction = 3;
        unitIDChoose = 4;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnCombatant()
    {
        unitFaction = 3;
        unitIDChoose = 5;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnMermaids()
    {
        unitFaction = 3;
        unitIDChoose = 6;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnLynwurm()
    {
        unitFaction = 3;
        unitIDChoose = 7;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnTakopod()
    {
        unitFaction = 3;
        unitIDChoose = 8;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnHydra()
    {
        unitFaction = 3;
        unitIDChoose = 9;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnSkyfalls()
    {
        unitFaction = 3;
        unitIDChoose = 10;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnCharybdis()
    {
        unitFaction = 3;
        unitIDChoose = 11;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnBattleship()
    {
        unitFaction = 3;
        unitIDChoose = 12;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnAttacksubs()
    {
        unitFaction = 3;
        unitIDChoose = 13;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnAmphipreters()
    {
        unitFaction = 3;
        unitIDChoose = 14;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnAircraftCarrires()
    {
        unitFaction = 3;
        unitIDChoose = 15;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    public void OnMotherfortess()
    {
        unitFaction = 2;
        unitIDChoose = 16;
        ShowUnitInfo();
        OnChangeSprite(unitFaction, unitIDChoose);
    }
    #endregion

    #region Misc function
    private void GetRealTime()
    {
        realTimeTxt.text = now.Hour.ToString() + ":" + now.Minute.ToString() + ":" + now.Second.ToString();
    }
    public void OnQuitGame() => Application.Quit(0);

    //Call from Capaign
    public void OnCampUIMP() => campFactionID = 0;
    public void OnCampLoVT() => campFactionID = 2;
    public void OnCampNEA() => campFactionID = 3;
    public void CampToWarfield() => ToWarfield(campFactionID, 1, 4*4);
    //End call from Campaign

    //Call from Skirmish
    public void PlayerPickUIPM() => skirmishPlayerFactionID = 1;
    public void PlayerPickLoVT() => skirmishPlayerFactionID = 3;
    public void PlayerPickNEA() => skirmishPlayerFactionID = 3;
    public void PlayerPickRandom() => skirmishPlayerFactionID = UnityEngine.Random.Range(1, 3);
    public void PlayerPickMapSize()
    {
        switch (mapSizeDrop.value)
        {
            case 0:
                mapSize = 3 * 3;
                break;
            case 1:
                mapSize = 4 * 4;
                break;
            case 2:
                mapSize = 5 * 5;
                break;
            case 3:
                mapSize = 6 * 6;
                break;
            case 4:
                mapSize = 7 * 7;
                break;
            case 5:
                mapSize = 8 * 8;
                break;
        }
    }
    public void PlayerPickFoeUIPM() => skirmishFoeFactionID = 1;
    public void PlayerPickFoeLoVT() => skirmishFoeFactionID = 2;
    public void PlayerPickFoeNEA() => skirmishFoeFactionID = 3;
    public void PlayerPickFoeRand() => skirmishFoeFactionID = UnityEngine.Random.Range(1, 3);
    public void SkirmishToWarfield() => ToWarfield(skirmishPlayerFactionID, skirmishFoeFactionID, mapSize);
    //End call form Skirmish

    public void Tutorial() => ToWarfield(1, 1, 3*3);
    private void ToWarfield(int _playerfaction, int _foeFaction, int mapSzie)
    {
        print("in to Warfiled Funct");
        ingameSC.SetSkirmishData(_playerfaction, _foeFaction, mapSzie);
        SceneManager.LoadScene("03_InGameScene");
    }
    #endregion
}

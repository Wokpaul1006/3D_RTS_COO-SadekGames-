using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameSC : MonoBehaviour
{
    public GameObject NewGameMN, chooseSideCapainMN;
    // Start is called before the first frame update
    void Start()
    {
        DisableAllMenu();
        NewGameMN.SetActive(true);
    }

    private void DisableAllMenu()
    {
        NewGameMN.SetActive(false);
        chooseSideCapainMN.SetActive(false);
    }

    public void ToCampaignMenu()
    {
        NewGameMN.SetActive(false);
        chooseSideCapainMN.SetActive(true);
    }

    public void UIPMCamp()
    {

    } 

    public void NargarCamp() { }

    public void LoVTCamp() { }

    public void ToTutorial()
    {

    }
    public void ToLobby()
    {
        SceneManager.LoadScene("SkirmishLobbyScene");
    }

    public void BackToNewGameMenu()
    {
        DisableAllMenu();
        NewGameMN.SetActive(true);
    }
}

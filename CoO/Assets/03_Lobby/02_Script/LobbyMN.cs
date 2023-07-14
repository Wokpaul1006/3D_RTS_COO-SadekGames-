using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyMN : MonoBehaviour
{
    [SerializeField] List<Dropdown> Factiondropdown;
    [SerializeField] List<Dropdown> Colordropdown;
    [SerializeField] List<GameObject> ChooseSide;
    [SerializeField] int TeamAmount;

    private void Start()
    {
        TeamAmount = 2;
    }

    public void PlayGames()
    {
        SceneManager.LoadScene("InGameScene");
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}

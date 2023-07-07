using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject MMPanel, NewGamePanel, LoadGamePanel, OptionPanel, LorePanel, InfoPanel,ShopPanel;
    // Start is called before the first frame update
    void Start()
    {
        showMainMenu();
    }

    public void DisableAllPanel()
    {
        MMPanel.SetActive(false);
        NewGamePanel.SetActive(false);
        LoadGamePanel.SetActive(false);
        OptionPanel.SetActive(false);
        LorePanel.SetActive(false);
        InfoPanel.SetActive(false);
    }

    public void showMainMenu()
    {
        DisableAllPanel();
        MMPanel.SetActive(true);
    }

    public void showNewGame()
    {
        DisableAllPanel();
        NewGamePanel.SetActive(true);
    }

    public void showLoadGame()
    {
        DisableAllPanel();
        LoadGamePanel.SetActive(true);
    }
    public void showOption()
    {
        DisableAllPanel();
        OptionPanel.SetActive(true);
    }
    public void showLore()
    {
        DisableAllPanel();
        LorePanel.SetActive(true);
    }

    public void showInfoPanel()
    {
        DisableAllPanel();
        InfoPanel.SetActive(true);
    }

    public void showShopPanel()
    {
        DisableAllPanel();
        ShopPanel.SetActive(true);
    }

    public void onQuitGame()
    {
        Application.Quit(0);
    }
}

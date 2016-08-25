using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public GameObject QuitGameText;
    public GameObject YesButton;
    public GameObject NoButton;
    public GameObject RestartButton;

    private LevelManager levelManager;

    void Awake()
    {
        levelManager = GameObject.FindGameObjectWithTag("T_LevelManager").GetComponent<LevelManager>();
    }

    public void CloseGame()
    {
        Application.Quit();
        print("Goodbye! Thanks for playing!");
    }

    public void RestartGame()
    {
        levelManager.ReloadLevel();
    }

    public void UnhideUI()
    {
        QuitGameText.SetActive(true);
        YesButton.SetActive(true);
        NoButton.SetActive(true);
        RestartButton.SetActive(true);
    }

    public void hideUI()
    {
        QuitGameText.SetActive(false);
        YesButton.SetActive(false);
        NoButton.SetActive(false);
        RestartButton.SetActive(false);
        print("Menu Deactivated");
    }
}

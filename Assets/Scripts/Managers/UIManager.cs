using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public GameObject QuitGameText;
    public GameObject YesButton;
    public GameObject NoButton;

    public void CloseGame()
    {
        Application.Quit();
        print("Goodbye! Thanks for playing!");
    }

    public void UnhideUI()
    {
        QuitGameText.SetActive(true);
        YesButton.SetActive(true);
        NoButton.SetActive(true);
    }

    public void hideUI()
    {
        QuitGameText.SetActive(false);
        YesButton.SetActive(false);
        NoButton.SetActive(false);
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private LevelManager levelManager;
    private UIManager UIManager;

    void Awake()
    {
        levelManager = GameObject.FindGameObjectWithTag("T_LevelManager").GetComponent<LevelManager>();
        UIManager = GameObject.FindGameObjectWithTag("T_UIManager").GetComponent<UIManager>();
    }
    public void LoadLevel(string levelID)
    {
        SceneManager.LoadScene(levelID); //Loads scene according to name (Can be int ID if needed)
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UIManager.UnhideUI();
            print("Menu Activated");
        }
    }

    public void LoadNextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;

        if (currentScene == nextScene)
        {
            Debug.Log("No next Scene!");
            return;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Loads the current scene again
    }
}

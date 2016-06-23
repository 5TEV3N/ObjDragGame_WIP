using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    LevelManager levelManager;
    void Awake()
    {
        levelManager = GameObject.FindGameObjectWithTag("T_LevelManager").GetComponent<LevelManager>();
    }
    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("T_Goal"))
        {
            levelManager.LoadNextLevel();
        }

        if (other.CompareTag("T_Floor"))
        {
            levelManager.ReloadLevel();
        }
    }
}

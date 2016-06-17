using UnityEngine;
using System.Collections;

public class LevelChanger : MonoBehaviour
{
    GameObject Escort;
    void Awake()
    {
        Escort= GameObject.FindGameObjectWithTag("T_Escort");
    }

    void OnCollisionEnter (Collision goal)
    {
       if (Escort)
        {
            print("Goal!");
        }
    }
}

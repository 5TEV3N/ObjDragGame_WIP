using UnityEngine;
using System.Collections;

public class MainMenuCheatCode : MonoBehaviour
{
    MainMenuCheatCode mainMenuCheatCode;
    int cheatCounter = 0;

	void Awake ()
    {
        mainMenuCheatCode = GameObject.FindGameObjectWithTag("T_MainMenuCheat").GetComponent<MainMenuCheatCode>();
	}
	
	void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.Delete))
            {
                cheatCounter++;
                print(cheatCounter);

                if (cheatCounter == 20)
                {
                    print(" C H E A T S  E N A B L E D");
                    // ADD CHEATS IN HERE
                }
            }
	}
}

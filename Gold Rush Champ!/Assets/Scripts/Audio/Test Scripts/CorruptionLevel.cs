using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorruptionLevel : MonoBehaviour
{
    float currentLevel = 1;
    bool mainTheme = true;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (currentLevel < 5)
            {
                currentLevel++;
                AkSoundEngine.SetRTPCValue("Corruption", currentLevel);
                print("Stage" + currentLevel);
            }
            else
            {
                currentLevel = 1;
                AkSoundEngine.SetRTPCValue("Corruption", currentLevel);
                print("Stage" + currentLevel);
            }
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            AkSoundEngine.PostEvent("Play_Walking", gameObject);
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            if (!Input.GetKey(KeyCode.A) || !Input.GetKey(KeyCode.D))
            {
                AkSoundEngine.PostEvent("Stop_Walking", gameObject);
            }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            if (mainTheme)
            {
                AkSoundEngine.PostEvent("Stop_Music", gameObject);
                AkSoundEngine.PostEvent("Play_MainMenuMusic", gameObject);
                mainTheme = false;
            }
            else
            {
                AkSoundEngine.PostEvent("Stop_MainMenuMusic", gameObject);
                AkSoundEngine.PostEvent("Play_Music", gameObject);
                mainTheme = true;
            }
        }
    }
}

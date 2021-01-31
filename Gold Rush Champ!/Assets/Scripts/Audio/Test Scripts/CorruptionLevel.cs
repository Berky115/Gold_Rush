using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorruptionLevel : MonoBehaviour
{
    float currentLevel = 1;
    bool mainTheme = true;
    int itemGetCategory = 1;
    
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

        if (Input.GetKeyDown(KeyCode.I))
        {
            if(itemGetCategory == 1)
            {
                AkSoundEngine.SetState("ItemType", "Normal");
                AkSoundEngine.PostEvent("Play_ItemGet", gameObject);
                itemGetCategory++;
            }
            else if(itemGetCategory == 2)
            {
                AkSoundEngine.SetState("ItemType", "Wierd");
                AkSoundEngine.PostEvent("Play_ItemGet", gameObject);
                itemGetCategory++;
            }
            else
            {
                AkSoundEngine.SetState("ItemType", "Cursed");
                AkSoundEngine.PostEvent("Play_ItemGet", gameObject);
                itemGetCategory = 1;
            }
        }
    }
}

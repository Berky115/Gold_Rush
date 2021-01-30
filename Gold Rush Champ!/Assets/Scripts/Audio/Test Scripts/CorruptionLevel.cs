using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorruptionLevel : MonoBehaviour
{
    float currentLevel = 1;
    
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
    }
}

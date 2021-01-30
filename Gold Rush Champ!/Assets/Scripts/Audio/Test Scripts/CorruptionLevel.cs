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
    }
}

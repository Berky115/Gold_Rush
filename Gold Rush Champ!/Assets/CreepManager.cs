using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreepManager : MonoBehaviour
{
    public float CreepyLevel = 1.0f;
    public float creepThreshold = 7.0f;
    private GameObject player;
    void Start()
    {
       player = FindObjectOfType<Camera>().gameObject;
    }

    public void increaseCreepLevel(float increaseValue){
        CreepyLevel += increaseValue;
        checkCreepyLevel();
    }

    public void checkCreepyLevel(){
        if(CreepyLevel > creepThreshold){
        Debug.Log("Transition to FinalBattle");
            AkSoundEngine.PostEvent("Stop_Music", player);
            AkSoundEngine.PostEvent("Stop_Ambience", player);
            SceneManager.LoadScene("FinalBattle");
        }
    }
}

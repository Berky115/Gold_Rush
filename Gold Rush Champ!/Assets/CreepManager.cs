using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreepManager : MonoBehaviour
{
    public float CreepyLevel = 1.0f;
    public const int MAX_PILE_SIZE = 15;
    // Original method for scene transition. May have use later.
    public float creepThreshold = 7.0f;

    public int pileSize = 0;
    private GameObject player;
    void Start()
    {
       player = FindObjectOfType<Camera>().gameObject;
    }

    public void increaseCreepLevel(float increaseValue){
        CreepyLevel += increaseValue;
        pileSize++;
        checkPileSize();
    }

    public void checkPileSize(){
        if(pileSize > MAX_PILE_SIZE){
        Debug.Log("Transition to FinalBattle");
            AkSoundEngine.PostEvent("Stop_Music", player);
            AkSoundEngine.PostEvent("Stop_Ambience", player);
            SceneManager.LoadScene("FinalBattle");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemSpawning : MonoBehaviour
{
    // Start is called before the first frame update


    GameObject player;
    public int delay = 1;
    public float CreepyLevel = 1;
    public float creepThreshold = 5;
    public GameObject riverItem;
    public List<Item> ItemList;
    public bool isRunning = true;
    public UnityEvent StartFinalBattle;
    void Start()
    {
        player = FindObjectOfType<Camera>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(isRunning == true){
            StartCoroutine(Wait());
        }
        
    }

    public IEnumerator Wait(){
        isRunning = false;
        yield return new WaitForSeconds(delay);
        Debug.Log("NEW OBJECT GENERATED");
        GameObject spawnedItem = Instantiate(riverItem, new Vector3(Random.Range(-5, 5), 2, 0), Quaternion.identity);
        int index = Random.Range(0, ItemList.Count);
        while(CreepyLevel < ItemList[index].CreepyRank){
            index = Random.Range(0, ItemList.Count); 
        }
        Debug.Log(ItemList[index].name);
        CreepyLevel += .05f;
        AkSoundEngine.SetRTPCValue("Corruption", CreepyLevel);
        spawnedItem.GetComponent<ObjectInfo>().data = ItemList[index];
        Debug.Log("Creepy Level at " + CreepyLevel);
        isRunning = true;
    }

    public void checkCreepyLevel(){
        if(CreepyLevel > creepThreshold){
            Debug.Log("Time to transition to the final battle!");

            if (StartFinalBattle != null) {
                AkSoundEngine.PostEvent("Stop_Music", player);
                AkSoundEngine.PostEvent("Stop_Ambience", player);
                StartFinalBattle.Invoke();
            }
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemSpawning : MonoBehaviour
{
    // Start is called before the first frame update

    public float delay = .25f;
    public GameObject riverItem;
    public List<Item> ItemList;
    public bool isRunning = true;
    void Start()
    {
        
    }

    void Update()
    {
        if(isRunning == true){
            StartCoroutine(generateItem());
        }
        
    }

    public IEnumerator generateItem(){
        isRunning = false;
        yield return new WaitForSeconds(delay);

        float CreepyLevel = GameObject.FindWithTag("CreepManager").GetComponent<CreepManager>().CreepyLevel;
        int index = Random.Range(0, ItemList.Count);
        Debug.Log("Creepy Rank " + ItemList[index].CreepyRank);
         Debug.Log("Creepy Level " + CreepyLevel);
        while(CreepyLevel < ItemList[index].CreepyRank){
            Debug.Log(CreepyLevel + " : " + ItemList[index].CreepyRank);
            index = Random.Range(0, ItemList.Count); 
        }

        GameObject spawnedItem = Instantiate(riverItem, new Vector3(Random.Range(-5, 5), 3, 0), Quaternion.identity);
        spawnedItem.GetComponent<ObjectInfo>().data = ItemList[index];
        AkSoundEngine.SetRTPCValue("Corruption", CreepyLevel);
        Debug.Log(ItemList[index].name);

        if (!spawnedItem.GetComponent<ObjectInfo>().data.RepeatIfThrownOut)
        {
           ItemList.Remove(spawnedItem.GetComponent<ObjectInfo>().data);
        }

        isRunning = true;
    }
}

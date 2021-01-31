using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawning : MonoBehaviour
{
    // Start is called before the first frame update

    public int delay = 1;
    public GameObject riverItem;
    public List<Item> ItemList;
    public bool isRunning = true;
    void Start()
    {

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
        Debug.Log(ItemList[index].name);
        spawnedItem.GetComponent<ObjectInfo>().data = ItemList[index];
        isRunning = true;
    }
    
}

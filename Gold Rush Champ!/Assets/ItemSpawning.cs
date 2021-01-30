using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawning : MonoBehaviour
{
    // Start is called before the first frame update

    public int delay = 1;
    public GameObject riverItem;
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
        Random.InitState(Random.Range(-3, 3)); //This is the seed
        Instantiate(riverItem, new Vector3(Random.Range(-3, 3), 0, 0), Quaternion.identity);
        isRunning = true;
    }
    
}

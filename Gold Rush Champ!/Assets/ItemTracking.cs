using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTracking : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Item> foundList;
    void Start()
    {
        
    }

    public void addFoundItem(string message) {
        // foundList.Add(item);
        Debug.Log(message);
    }

}

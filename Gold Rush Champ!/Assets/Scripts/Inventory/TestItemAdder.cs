using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItemAdder : MonoBehaviour
{
    public Item[] FoundItemsList;
    int itemIndex = 0;
    bool firstUpdate = true;

    public Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (firstUpdate)
        {
            //Add ALL Items to found list
            inventory.AddFound(FoundItemsList);
            Debug.Log("A bunch of Items were found");
            firstUpdate = false;
        }


        if(Input.GetKeyUp(KeyCode.Space)){
            if(itemIndex < FoundItemsList.Length-1)
            {
                //KEEP ITEM
                inventory.KeepItem(FoundItemsList[itemIndex]);

                itemIndex++;
                Debug.Log("The Item: "+ FoundItemsList[itemIndex].Name + " was Kept");
            }
        }

        if (Input.GetKeyUp(KeyCode.Backspace))
        {
            if (itemIndex < FoundItemsList.Length-1)
            {
                //THROGH AWAY
                inventory.ThrowOut(FoundItemsList[itemIndex]);

                itemIndex++;
                Debug.Log("The Item: " + FoundItemsList[itemIndex].Name + " was Thrown Away");
            }
        }
    }
}

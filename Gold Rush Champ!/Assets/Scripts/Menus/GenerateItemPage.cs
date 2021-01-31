using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateItemPage : MonoBehaviour
{
    private Sprite itemSprite;
    private Text itemName;
    private Text itemDesc;
    private Item currentItem;

    
    //setting variables
    private void Start()
    {
        currentItem = gameObject.GetComponent<ObjectInfo>().data;
        itemSprite = null;
        itemName.text = null;
        itemDesc.text = null;
    }


    //excutes script to fill out item page
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            itemSprite = currentItem.ItemImage;
            itemName.text = currentItem.Name;
            itemDesc.text = currentItem.Description;
            Debug.Log("Item menu generating");
            ItemDescriptionPage.ShowItem_Static(itemSprite, itemName.text, itemDesc.text);
        }
    }
    
}

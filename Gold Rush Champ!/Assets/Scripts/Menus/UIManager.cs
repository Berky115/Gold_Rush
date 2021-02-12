using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    private Image image;
    private Text nameText;
    private Text descriptionText;
    public Item itemData;

    public GameObject UI_PANEL_ITEM_POP_UP;

    //sets initial variables
    private void Awake()
    {
         instance = this;
        // gameObject.SetActive(false);
    }

    //sets the item info to be displayed
    public void ShowItemInfo(Sprite itemSprite, string itemName, string itemDesc, Item itemData)
    {
        UI_PANEL_ITEM_POP_UP.SetActive(true);
        GameObject.Find("UI_ITEM_IMAGE").GetComponent<Image>().sprite = itemSprite;
        GameObject.Find("UI_ITEM_NAME").GetComponent<Text>().text = itemName;
        GameObject.Find("UI_ITEM_DESCRIPTION").GetComponent<Text>().text = itemDesc;
        this.itemData = itemData;
        PauseControl.Pause();
    }
    
    public void HideItemInfo()
    {
        UI_PANEL_ITEM_POP_UP.SetActive(false);
        PauseControl.Resume();
    }

    public void ShowItem_Static(Item data)
    {
        ShowItemInfo(data.ItemImage, data.Name, data.Description, data);
    }

    public void sendItemToFoundList() {
        GameObject.Find("Inventory").GetComponent<Inventory>().KeepItem(itemData);
        GameObject.FindWithTag("CreepManager").GetComponent<CreepManager>().increaseCreepLevel(.2f); 
        HideItemInfo();
    }

}

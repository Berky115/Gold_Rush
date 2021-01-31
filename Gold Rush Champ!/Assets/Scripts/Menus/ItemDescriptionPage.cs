using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDescriptionPage : MonoBehaviour
{
    private static ItemDescriptionPage instance;
    private Image image;
    private Text nameText;
    private Text descriptionText;


    //sets initial variables
    private void Awake()
    {
        instance = this;
        image = transform.Find("Image").GetComponent<Image>();
        nameText = transform.Find("Item Name").GetComponent<Text>();
        descriptionText = transform.Find("Item Description").GetComponent<Text>();
        gameObject.SetActive(false);
    }

    //sets the item info to be displayed
    private void ShowItemInfo(Sprite itemSprite, string itemName, string itemDesc)
    {
        gameObject.SetActive(true);
        image.sprite = itemSprite;
        nameText.text = itemName.ToString();
        descriptionText.text = itemDesc.ToString();
        PauseControl.Pause();
    }
    
    //closes window
    private void HideItemInfo()
    {
        gameObject.SetActive(false);
        PauseControl.Resume();
    }

    //static function for reference elsewhere
    public static void ShowItem_Static(Sprite itemSprite, string itemName, string itemDesc)
    {
        instance.ShowItemInfo(itemSprite, itemName, itemDesc);
    }

    public static void HideItem_Static()
    {
        instance.HideItemInfo();
    }

    
}

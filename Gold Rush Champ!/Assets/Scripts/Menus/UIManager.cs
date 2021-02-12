using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public bool gameIsPaused = false;
    private Image image;
    private Text nameText;
    private Text descriptionText;
    public Item itemData;
    public GameObject UI_PANEL_ITEM_POP_UP;
    public GameObject UI_PANEM_PAUSE_MENU;
    public GameObject UI_PANEL_INSTRUCTIONS;

    private void Awake()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
                UI_PANEM_PAUSE_MENU.SetActive(false);
            }
            else
            {
                Pause();
                UI_PANEM_PAUSE_MENU.SetActive(true);
            }
        }
    }

    public void ShowItemInfo(Sprite itemSprite, string itemName, string itemDesc, Item itemData)
    {
        UI_PANEL_ITEM_POP_UP.SetActive(true);
        GameObject.Find("UI_ITEM_IMAGE").GetComponent<Image>().sprite = itemSprite;
        GameObject.Find("UI_ITEM_NAME").GetComponent<Text>().text = itemName;
        GameObject.Find("UI_ITEM_DESCRIPTION").GetComponent<Text>().text = itemDesc;
        this.itemData = itemData;
        Pause();
    }

    
    public void ShowInstructions()
    {
        UI_PANEM_PAUSE_MENU.SetActive(false);
        UI_PANEL_INSTRUCTIONS.SetActive(true);
        Pause();
    }


    
    public void HideItemInfo()
    {
        UI_PANEL_ITEM_POP_UP.SetActive(false);
        Resume();
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

    
    public void Resume()
    {
        gameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        gameIsPaused = true;
        Time.timeScale = 0f;
    }

}

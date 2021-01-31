using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    //Item Lists
    private List<Item> FoundItems;
    //private List<Item> ThrownAwayItems;
    // private List<Item> KeptItems;
    //public List<Item> FoundItems;
    //public List<Item> ThrownAwayItems;
    public List<Item> KeptItems;

    private ItemPileManager itemPile;

    public void AddFound(Item foundItem)
    {
        FoundItems.Add(foundItem);
    }

    public void AddFound(IEnumerable<Item> itemsFound)
    {
        foreach (Item foundItem in itemsFound)
        {
            AddFound(foundItem);
        }
    }

    //public void ThrowOut(Item thrownOutItem)
    //{
    //    ThrownAwayItems.Add(thrownOutItem);
    //}

    public void KeepItem(Item keepItem)
    {
        KeptItems.Add(keepItem);
        itemPile.UpdateModeSprites(KeptItems);
    }

    public List<Item> GetKeptItems()
    {
        return KeptItems;
    }


    private void Start()
    {
        FoundItems = new List<Item>();
        KeptItems = new List<Item>();
        //ThrownAwayItems = new List<Item>();

        itemPile = GetComponent<ItemPileManager>();
    }

    public void ReloadPile()
    {
        itemPile.UpdateModeSprites(KeptItems);
    }

    //private void Update()
    //{
    //    //TEST CODE
    //    if (KeptItems.Count == 0)
    //    {
    //        foreach (Item foundThing in FoundItems)
    //        {
    //            AddKeepItem(foundThing);
    //        }
    //    }
    //}


}

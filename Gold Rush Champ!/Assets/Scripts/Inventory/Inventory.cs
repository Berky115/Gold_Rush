using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    //public Item[] CreateTest;

    //Item Lists
    public List<Item> FoundItems;
    public List<Item> ThrownAwayItems;
    public List<Item> KeptItems;

    public void AddFound(Item foundItem)
    {
        FoundItems.Add(foundItem);
    }

    public void AddThownOut(Item thrownOutItem)
    {
        ThrownAwayItems.Add(thrownOutItem);
    }

    public void AddKeepItem(Item keepItem)
    {
        KeptItems.Add(keepItem);
    }


    //private void Start()
    //{
    //    //Testing
    //    //FoundItems.Add(CreateTest);
    //    //FoundItems.Add(CreateTest);

    //}


}

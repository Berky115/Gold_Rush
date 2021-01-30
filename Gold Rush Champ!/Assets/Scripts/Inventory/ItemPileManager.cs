using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPileManager : MonoBehaviour
{
    public SpriteRenderer[] SpritePile;


    // Start is called before the first frame update
    void Start()
    {
        //Clear all sprites
        foreach(SpriteRenderer sprite in SpritePile)
        {
            sprite.sprite = null;
        }
    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    public void UpdateModeSprites(List<Item> KeptItems)
    {
        for(int i= 0; i< KeptItems.Count; i++)
        {
            if(i> SpritePile.Length - 1)
            {
                Debug.Log("Not enough sprites to show kept items");
            }
            else
            {
                //Set The Sprite
                SpritePile[i].sprite = KeptItems[i].ItemImage;

            }
        }
    }



}

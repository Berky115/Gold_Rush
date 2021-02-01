using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithPlayer : MonoBehaviour
{
    PlayerAudio playerAudio;
    // Start is called before the first frame update

    void Start()
    {
        playerAudio = FindObjectOfType<PlayerAudio>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        // called when this GameObject collides with GameObject2.
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("GameObject1 collided with " + col.name);
            Debug.Log(gameObject.GetComponentInParent<ObjectInfo>().data.Description);
            
            // GameObject.Find("ItemManager").GetComponent<ItemTracking>().foundList.Add(gameObject.GetComponentInParent<ObjectInfo>().data);
            if (!gameObject.GetComponentInParent<ObjectInfo>().data.RepeatIfThrownOut)
            {
                GameObject.Find("ItemManager").GetComponent<ItemSpawning>().ItemList.Remove(gameObject.GetComponentInParent<ObjectInfo>().data);
            }
            PlayAudio();
            Destroy(transform.parent.gameObject);
            //appending item menu pop-up
            Sprite itemSprite = gameObject.GetComponentInParent<ObjectInfo>().data.ItemImage;
            Item data = gameObject.GetComponentInParent<ObjectInfo>().data;
            string itemName = gameObject.GetComponentInParent<ObjectInfo>().data.Name;
            string itemDesc = gameObject.GetComponentInParent<ObjectInfo>().data.Description;
            ItemDescriptionPage.ShowItem_Static(itemSprite, itemName, itemDesc, data);
        }

    }

    private void PlayAudio()
    {
        string itemType = gameObject.GetComponentInParent<ObjectInfo>().data.itemType;
        playerAudio.PlayItemCollect(itemType);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithPlayer : MonoBehaviour
{
    PlayerAudio playerAudio;

    void Start()
    {
        playerAudio = FindObjectOfType<PlayerAudio>();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("GameObject " + col.name + " collidated with player");
            
            PlayAudio();
            Destroy(transform.parent.gameObject);

            //appending item menu pop-up
            GameObject.Find("UIManager").GetComponent<UIManager>().ShowItem_Static(gameObject.GetComponentInParent<ObjectInfo>().data);
        }
    }

    private void PlayAudio()
    {
        string itemType = gameObject.GetComponentInParent<ObjectInfo>().data.itemType;
        playerAudio.PlayItemCollect(itemType);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        // called when this GameObject collides with GameObject2.
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player") {
            Debug.Log("GameObject1 collided with " + col.name);
            Debug.Log(gameObject.GetComponentInParent<ObjectInfo>().data.Description);
            GameObject.Find("ItemManager").GetComponent<ItemTracking>().foundList.Add(gameObject.GetComponentInParent<ObjectInfo>().data);
            if(gameObject.GetComponentInParent<ObjectInfo>().data.RepeatIfThrownOut){
                //stubbed out for conditional
            }
            Destroy(gameObject);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAndDestroy : MonoBehaviour
{
    public string TargetName;

    public void DestroyTarget()
    {
        GameObject target = GameObject.Find(TargetName);
        if(target != null)
        {
            Destroy(target);
        }
        else
        {
            Debug.Log("Could not find "+TargetName);
        }
    }


}

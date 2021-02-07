using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growAtSpawn : MonoBehaviour
{
    private Vector3 scaleChange;

    void Awake()
    {
        scaleChange = new Vector3(0.005f, 0.005f, 0.005f);
    }

    void Update()
    {
        this.gameObject.transform.localScale += scaleChange;

        // Move upwards when the sphere hits the floor or downwards
        // when the sphere scale extends 1.0f.
        if (this.gameObject.transform.localScale.y < 0.1f || this.gameObject.transform.localScale.y > .5f)
        {
            scaleChange = scaleChange * 0;
        }
    }
}

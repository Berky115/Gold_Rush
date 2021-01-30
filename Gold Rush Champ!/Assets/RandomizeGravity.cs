using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeGravity : MonoBehaviour
{
    // Start is called before the first frame update
    public float low = .2f;
    public float high = 3.0f;
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().gravityScale = Random.Range(low, high);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

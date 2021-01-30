using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_right_movement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float multiplier = 1.5f;
    void Start () {
   
    }
   
    void Update ()
    {                     
        transform.Translate(Vector3.right * Time.deltaTime*multiplier * Input.GetAxis("Horizontal")* moveSpeed);      
    }
}

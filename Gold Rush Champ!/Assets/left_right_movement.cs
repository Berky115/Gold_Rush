using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_right_movement : MonoBehaviour
{
    public float moveSpeed = 3f;
    void Start () {
   
    }
   
    void Update ()
    {                         //Left/Right
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal")* moveSpeed);      
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
<<<<<<< HEAD
 public float moveSpeed = 3f;
=======
        public float moveSpeed = 3f;
    // Use this for initialization
>>>>>>> main
    void Start () {
   
    }
   
<<<<<<< HEAD
=======
    // Update is called once per frame
>>>>>>> main
    void Update ()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal")* moveSpeed);      
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> main

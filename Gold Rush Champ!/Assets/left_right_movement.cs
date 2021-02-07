using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_right_movement : MonoBehaviour
{
    public float moveSpeed = 8f;
    public float multiplier = 3f;
    
    //Reference to Walking Audio
    PlayerAudio playerAudio;
    private bool isPlaying;

    void Start () 
    {
        playerAudio = FindObjectOfType<PlayerAudio>();
    }
   
    void Update ()
    {
        transform.Translate(Vector3.right * Time.deltaTime * multiplier * Input.GetAxis("Horizontal") * moveSpeed);
        PlayWalkingAudio();
    }

    private void PlayWalkingAudio()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            if (!isPlaying)
            {
                playerAudio.AudioEvent("Play_Walking");
                isPlaying = true;
            }
        }
        else
        {
            playerAudio.AudioEvent("Stop_Walking");
            isPlaying = false;
        }
    }
}

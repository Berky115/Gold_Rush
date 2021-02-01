using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public void PlayItemCollect(string itemType)
    {
        AkSoundEngine.SetState("ItemType", itemType);
        AkSoundEngine.PostEvent("Play_ItemGet", gameObject);
    }

    public void AudioEvent(string eventName)
    {
        AkSoundEngine.PostEvent(eventName, gameObject);
    }
}

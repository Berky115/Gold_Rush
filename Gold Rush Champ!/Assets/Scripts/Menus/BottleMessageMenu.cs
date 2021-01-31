using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottleMessageMenu : MonoBehaviour
{

    public static BottleMessageMenu instance;

    private Text messageText;

    //sets initial variables
    private void Awake()
    {
        instance = this;
        messageText = transform.Find("Text").GetComponent<Text>();
    }

    private void ShowMessage(string message)
    {
        gameObject.SetActive(true);
        messageText.text = message;

    }

    private void HideMessage()
    {
        gameObject.SetActive(false);
    }

    public static void ShowMessage_Static(string message)
    {
        instance.ShowMessage(message);
    }

    public static void HideMessage_Static()
    {
        instance.HideMessage();
    }
}

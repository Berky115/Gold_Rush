using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCardTest : MonoBehaviour
{
    private static ItemCardTest instance;
    private Image test;

    private void Awake()
    {
        instance = this;
        test = transform.Find("Image").GetComponent<Image>();
    }
    //Start is called before the first frame update
    private void TestButton()
    {
        ItemDescriptionPage.ShowItem_Static(test.sprite, "Smitty J", "He was Number 1");
    }

    public static void Test_Static()
    {
        instance.TestButton();
    }

    
}

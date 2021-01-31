using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackInfoUI : MonoBehaviour
{
    public Text Title;
    public Text AttackDescription;
    public Image Image;

    public void SetUI(Item item)
    {
        Title.text = item.Name;
        AttackDescription.text = item.AttackText;
        Image.sprite = item.ItemImage;
    }
}

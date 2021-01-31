using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActionUI : MonoBehaviour
{

    public Text Title;
    public Text AttackDescription;

    public void DisplayText(string title, string description)
    {
        //Title.text = title;
        AttackDescription.text = description;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Item", menuName = "Create Gold Rush Item", order = 1)]
public class Item : ScriptableObject
{
    public string Name;
    public Sprite ItemImage;

    [TextArea]
    public string Description;

    public bool RepeatIfThrownOut;
    public bool IsCursed;

}

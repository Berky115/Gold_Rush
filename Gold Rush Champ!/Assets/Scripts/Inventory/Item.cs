using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Item", menuName = "Gold Rush/Create Item", order = 1)]
public class Item : ScriptableObject
{
    public string Name;
    public Sprite ItemImage;

    [TextArea]
    public string Description;

    public bool RepeatIfThrownOut;
    public bool IsCursed;
    public int CreepyRank;

    [TextArea(1, 5)]
    public string AttackText;
    public int AttackDamage = 0;

    public string itemType;
}

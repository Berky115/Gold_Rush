using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Message", menuName = "Gold Rush/Create Message", order = 1)]
public class BottleMessage : ScriptableObject
{
    public string Title;

    [TextArea(5, 50)]
    public string Text;
}

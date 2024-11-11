using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    public string ItemNumber;
    public Sprite Image;
    [TextArea]
    public string ItemInfo;
}

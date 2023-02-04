using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public string itemName;
    [field: TextArea]
    public string description;
    public GameObject model;
    public Sprite icon;
    public bool canCombine;
    public bool canDiscard;
}

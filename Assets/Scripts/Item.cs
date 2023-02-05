using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName ="ScriptableObject/Item")]
public class Item : ScriptableObject
{
   public string name;
   public TileBase tile;
   public Sprite image;
   public bool stackable;
   public bool fusionable;  
}

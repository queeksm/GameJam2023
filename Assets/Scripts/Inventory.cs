using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public ItemData [] items;
    public int maxSlots = 1;

    private void Start() {
        items = new ItemData[maxSlots];
    }

    public void AddItem(CollectableItem collectable)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = collectable.collectItem();
                return;
            }
        }
    }
}

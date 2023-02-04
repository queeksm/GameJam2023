using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    public ItemData item;
    public ItemData collectItem() {
        Destroy(gameObject);
        return item;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    // Start is called before the first frame update
    public bool taken = false;
    public void OnDrop(PointerEventData eventData)
    {
        if(transform.childCount == 0)
        {
        GameObject dropped = eventData.pointerDrag;
        InventoryItem draggableItem = dropped.GetComponent<InventoryItem>();
        draggableItem.parentAfterDrag = transform;
        taken = true;
        }
    }

    public void ClearSlot(){
        transform.DetachChildren();
    }
}

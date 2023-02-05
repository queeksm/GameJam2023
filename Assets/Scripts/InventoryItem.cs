using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryItem : MonoBehaviour, IDragHandler ,IBeginDragHandler, IEndDragHandler{

    
    [HideInInspector] public Item item;
    public Image image;
    
    [HideInInspector] public Transform parentAfterDrag;

    public void InitializeItem(Item newitem){
        item = newitem;
        image.sprite = newitem.image;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        image.raycastTarget = false;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        
    }

    public void OnDrag(PointerEventData eventData)
    {   
        transform.position = Input.mousePosition;
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }
    
    

    
}

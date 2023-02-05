using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryItem : MonoBehaviour, IDragHandler ,IBeginDragHandler, IEndDragHandler, IDropHandler{

    
    [HideInInspector] public Item item;   

    public InventoryManager inventoryManager;
    public Image image;

    [HideInInspector] public string name;
    
    [HideInInspector] public Transform parentAfterDrag;

    public void InitializeItem(Item newitem){
        item = newitem;
        name = newitem.name;
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

    public void OnDrop(PointerEventData eventData){        
        if(item.fusionable){
            switch (eventData.pointerDrag.GetComponent<InventoryItem>().name)
            {   
                case "knife":                    
                    
                    this.gameObject.GetComponentInParent<InventorySlot>().taken = false;
                    this.gameObject.GetComponentInParent<InventorySlot>().ClearSlot();                    
                    Destroy(this.gameObject);
                    inventoryManager = GameObject.Find("InventoryManager").GetComponent<InventoryManager>();
                    inventoryManager.AddItem(GameObject.Find("AllObjects").GetComponent<ObjectList>().items[3]);
                    break;
                
                default:                    
                    break;
            }
        }
    }


}

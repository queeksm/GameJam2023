using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TriggerInteraction : MonoBehaviour, IDropHandler
{

    [SerializeField]
    private Item item;
    public void OnDrop(PointerEventData eventData)
    {       
       if (item.name == eventData.lastPress.name)
       {
            this.GetComponent<Image>().color = Color.red;
       }
    }
}

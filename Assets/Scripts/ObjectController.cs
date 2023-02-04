using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour{

    [SerializeField]    
    private RectTransform lel;
    

    public void OnMouseDrag() {
        lel.position = Input.mousePosition;
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour
{  [SerializeField]
    private Canvas puzzle;    
    public int delta = 1;    
    private Vector3 right =  new Vector3(1,0,0) ;
    private Vector3 up =  new Vector3(0,1,0);
    public GameObject player;
    
    private void Start() {
        puzzle.GetComponent<Canvas>().enabled = false;
    }     
    
    private void OnTriggerEnter2D(Collider2D other) {
        

        Item knife =  GameObject.Find("AllObjects").GetComponent<ObjectList>().items[0];
        InventoryManager inventoryManager = GameObject.Find("InventoryManager").GetComponent<InventoryManager>();
        switch (other.name)
        {
            case "Mama":               
                delta = 0;
                puzzle.GetComponent<Canvas>().enabled = true;
                Destroy(GameObject.Find("Invis_Wall"));
                if (!inventoryManager.HasItem(knife))
                    inventoryManager.AddItem(knife);
                    other.GetComponent<CircleCollider2D>().radius = 0;
                break;
            case "Start":
                delta = 0;
                puzzle.GetComponent<Canvas>().enabled = true;                
                if (!inventoryManager.HasItem(knife))
                    inventoryManager.AddItem(knife);
                    other.GetComponent<CircleCollider2D>().radius = 0;
                break;
            case "PnC Ramas":
                delta = 0;
                puzzle.GetComponent<Canvas>().enabled = true;                
                break;

            default:
                break;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
                
    }
    

    

    private void Update() {        

        
        switch (Input.inputString)
        {
            case "w":
                player.transform.position += up * delta;
                                
                break;
            case "s":
                player.transform.position -= up * delta;
                 
                break;
            case "a":
                player.transform.position -= right  * delta;
                 
                break;
            case "d":
                player.transform.position += right * delta;
                
                break;
            case "e":
                delta = 1;            
                puzzle.GetComponent<Canvas>().enabled = !puzzle.GetComponent<Canvas>().enabled;
                break;
            
            default:
                break;            
        }


        
    }
}

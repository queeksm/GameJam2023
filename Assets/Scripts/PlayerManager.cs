using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour
{  [SerializeField]
    private Canvas puzzle;

    [SerializeField]
    private Inventory inventory;
    public int delta = 1;
    private bool withinPuzzleRange = false;
    private Vector3 right =  new Vector3(1,0,0) ;
    private Vector3 up =  new Vector3(0,1,0);
    public GameObject player;
    
    private void Start() {
        puzzle.GetComponent<Canvas>().enabled = false;
    }     
    
    private void OnTriggerEnter2D(Collider2D other) {
        withinPuzzleRange = true;
        
        if (other.tag == "Collectable")
        {
            inventory.AddItem(other.GetComponentInParent<CollectableItem>());
                        
        }             
    }

    private void OnTriggerExit2D(Collider2D other) {
        withinPuzzleRange =  false;        
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
            case "m":
                if (withinPuzzleRange){
                    delta = 0;
                    puzzle.GetComponent<Canvas>().enabled = true;
                }

                
                break;
            case "n":
                delta = 1;
                puzzle.GetComponent<Canvas>().enabled = false;
                break;
            default:
                break;            
        }


        
    }
}

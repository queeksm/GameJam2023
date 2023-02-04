using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    [SerializeField]
    private Canvas puzzleMenu;
    [SerializeField]
    private GameObject player;
    
    public void hideCanvas(){
        puzzleMenu.GetComponent<Canvas>().enabled = false;
        player.GetComponent<PlayerManager>().delta = 1;
    }

}

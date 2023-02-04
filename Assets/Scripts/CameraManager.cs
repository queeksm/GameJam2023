using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    private Vector3 smoothPos;
    

    
    private void FixedUpdate() {
        smoothPos = Vector3.Lerp(this.transform.position,new Vector3(player.position.x,player.position.y,this.transform.position.z),0.1f);
        this.transform.position = smoothPos;
    }
}

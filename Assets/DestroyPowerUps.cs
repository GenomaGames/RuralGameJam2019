using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPowerUps : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        BubbleController bubble = other.GetComponent<BubbleController>();
        if(bubble != null){
            Destroy(bubble.gameObject);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WagonController : MonoBehaviour
{

    [SerializeField]
    private PlayerController player;

    void OnCollisionEnter2D (Collision2D other) {
        PlayerController otherPlayer = other.gameObject.GetComponent<PlayerController>();

        Debug.Log("HIT");

        if (otherPlayer != null) {
            Debug.Log("STEAL");
            otherPlayer.Steal(player);
        }
    }
}

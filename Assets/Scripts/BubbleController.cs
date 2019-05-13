using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{

    public float O2Amount {
        get {
            return o2Amount;
        }
    }

    [SerializeField]
    private float o2Amount = 1;

    void OnCollisionEnter2D (Collision2D other) {
        PlayerController player = other.gameObject.GetComponent<PlayerController>();

        if (player != null && !player.IsDead) {
            player.RefillO2(o2Amount);
            Die();
        }
    }

    public void Die () {
        Destroy(gameObject);
    }
}

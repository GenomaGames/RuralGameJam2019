using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private PlayerController player;

    void Awake () {
        player = FindObjectOfType<PlayerController>();
    }

    void Update () {
        player.Rotate(Input.GetAxis("Horizontal"));
        player.Propel(Input.GetButton("Fire1"));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotor : MonoBehaviour
{

    public float speed = 1;

    [HideInInspector]
    public float rotation;

    private Rigidbody2D rigidBody2D;

    void Awake () {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate () {
        rigidBody2D.AddTorque(rotation * speed);
    }
}

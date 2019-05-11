using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    [HideInInspector]
    public bool isPropeling = false;

    [SerializeField]
    private float maxSpeed = 5;
    private float sqrMaxSpeed;


    private Rigidbody2D rigidBody2D;

    void Awake () {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Start () {
        sqrMaxSpeed = Mathf.Pow(maxSpeed, 2);
    }

    void FixedUpdate () {
        if (isPropeling) {
            float currentSpeed = rigidBody2D.velocity.sqrMagnitude;
            float sqrSpeedThresold = maxSpeed - currentSpeed;
            Vector2 force = Vector2.right * Mathf.Sqrt(sqrSpeedThresold);
            rigidBody2D.AddRelativeForce(force, ForceMode2D.Force);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Motor))]
[RequireComponent(typeof(Rotor))]
public class PlayerController : MonoBehaviour
{
    private Motor motor;
    private Rotor rotor;

    void Awake () {
        motor = GetComponent<Motor>();
        rotor = GetComponent<Rotor>();
    }

    public void Propel (bool isPropeling) {
        motor.isPropeling = isPropeling;
    }

    public void Rotate (float rotation) {
        rotor.rotation = rotation;
    }
}

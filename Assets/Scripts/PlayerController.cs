using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Motor))]
[RequireComponent(typeof(Rotor))]
public class PlayerController : MonoBehaviour
{
    public bool IsDead {
        get {
            return o2tank.CurrentO2 <= 0;
        }
    }

    public int Score {
        get {
            return (o2tank.CurrentO2 < 0 ? 0 : (int)Mathf.Floor(o2tank.CurrentO2));
        }
    }
    private Motor motor;
    private Rotor rotor;
    private O2Tank o2tank;

    void Awake () {
        motor = GetComponent<Motor>();
        rotor = GetComponent<Rotor>();
        o2tank = GetComponent<O2Tank>();
    }

    public void Propel (bool isPropeling) {
        motor.isPropeling = isPropeling;
    }

    public void Rotate (float rotation) {
        rotor.rotation = rotation;
    }
}

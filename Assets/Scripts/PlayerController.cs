using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Motor))]
[RequireComponent(typeof(Rotor))]
[RequireComponent(typeof(O2Tank))]
public class PlayerController : MonoBehaviour
{

    public float O2 {
        get {
            return o2tank.CurrentO2;
        }
    }

    public bool IsDead {
        get {
            return O2 <= 0;
        }
    }

    public int Score {
        get {
            return (O2 <= 0 ? 0 : (int)Mathf.Floor(O2));
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

    public void RefillO2 (float amount) {
        o2tank.AddO2(amount);
    }

    public float TakeO2 (float amount) {
        return o2tank.SubtractO2(amount);
    }

    public void Steal (PlayerController otherPlayer) {
        // Debug.Log(name + " Steals " + otherPlayer.name);
        float stolenO2 = otherPlayer.TakeO2(otherPlayer.O2 / 2f);
        RefillO2(stolenO2);
    }
}

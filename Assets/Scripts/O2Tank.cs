using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2Tank : MonoBehaviour
{

    public float CurrentO2 {
        get {
            return currentO2;
        }
    }

    [SerializeField]
    private float initialO2 = 10;
    private float currentO2;
    private float startTime;

    void Start () {
        currentO2 = initialO2;
    }

    void FixedUpdate () {
        SubtractO2(Time.fixedDeltaTime);
    }

    public void AddO2 (float amount) {
        currentO2 += amount;
    }

    public float SubtractO2 (float amount) {
        float lostO2 = 0;

        if (amount > currentO2) {
            lostO2 = currentO2;
            currentO2 = 0;
        } else {
            lostO2 = amount;
            currentO2 -= amount;
        }

        return lostO2;
    }
}

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
    private float initialO2 = 100;
    private float currentO2;
    private float startTime;

    void Start () {
        currentO2 = initialO2;
    }

    void FixedUpdate () {
        float o2ToSubtract = Time.deltaTime;
        currentO2 -= o2ToSubtract;
    }
}

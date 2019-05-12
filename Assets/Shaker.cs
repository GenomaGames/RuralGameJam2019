using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{

    [SerializeField]
    private float move = 1;

   private Rigidbody2D rigidBody2D;

   private float timer = 0f;

   void Awake() {
       rigidBody2D = GetComponent<Rigidbody2D>();
   }

   void FixedUpdate() {
       timer += Time.deltaTime;

       if (timer > Random.Range(.5f, 1f)) {
           rigidBody2D.velocity = new Vector2(move * Random.Range(-1f, 1f), rigidBody2D.velocity.y);
        //    rigidBody2D.AddForce(Vector2.right * move * Random.Range(-1f, 1f), ForceMode2D.Impulse);
           timer = 0;
       }
   }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject bubblePrefab;
    [SerializeField]
    private float randomTimeMin = 0.5f;
    [SerializeField]
    private float randomTimeMax = 5f;
    private Collider2D collider2D;
    private AudioSource audioSource;

    public AudioClip[] spawnSounds;

    void Awake(){
        collider2D = GetComponent<Collider2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Start(){
        Invoke("RandomBubble", randomTimeMin);
    }
 
    void RandomBubble(){
        float randomTime = Random.Range(randomTimeMin, randomTimeMax);

        SpawnBubble();

        Invoke("RandomBubble", randomTime);
    }

    private void SpawnBubble(){
        float origin = Random.Range(collider2D.bounds.min.x, collider2D.bounds.max.x);
        Vector2 position = new Vector2(origin, collider2D.transform.position.y);
        Instantiate(bubblePrefab, position, Quaternion.identity, transform);
        int i = Random.Range(0, spawnSounds.Length - 1);
        audioSource.PlayOneShot(spawnSounds[i]);
    }
}

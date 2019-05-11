using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private PlayerManager playerManager;
    private PlayerController[] players;

    void Awake () {
        playerManager = FindObjectOfType<PlayerManager>();
    }
    
    void Start () {
        players = playerManager.players;
    }

    void Update () {
      
    }
}

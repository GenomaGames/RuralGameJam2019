using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
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
        for (int i = 0; i < players.Length; i++)
        {
            if(players[i].IsDead) continue;
            HandlePlayerInputs(i + 1, players[i]);
        }
    }

    void HandlePlayerInputs (int playerNum, PlayerController player) {
        player.Rotate(Input.GetAxis("Player " + playerNum + " Horizontal"));
        player.Propel(Input.GetButton("Player " + playerNum + " Propel"));
    }
}

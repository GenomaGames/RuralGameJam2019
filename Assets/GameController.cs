using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        for (int i = 0; i < players.Length; i++){
            if(players[i].IsDead){
                SceneManager.LoadScene(0);
            }
        }
    }
}

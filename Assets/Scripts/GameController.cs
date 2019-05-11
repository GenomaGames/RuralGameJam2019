using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private PlayerManager playerManager;
    private HUDController hudController;
    private PlayerController[] players;
    private bool isGameEnded = false;

    void Awake () {
        playerManager = FindObjectOfType<PlayerManager>();
        hudController = FindObjectOfType<HUDController>();
    }
    
    void Start () {
        players = playerManager.players;
    }

    void Update () {
        if (isGameEnded) return;

        for (int i = 0; i < players.Length; i++) {
            if (players[i].IsDead) {
                hudController.ShowWinScreen(i == 1 ? "1" : "2");
                isGameEnded = true;
            }
        }
    }

    public void RestartGame () {
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private PlayerManager playerManager;
    private PlayerController[] players;

    public Text[] scoreTexts;

    void Awake () {
        playerManager = FindObjectOfType<PlayerManager>();
    }
    
    void Start () {
        players = playerManager.players;
    }

    void Update () {
        for (int i = 0; i < players.Length; i++)
        {
            if (scoreTexts[i]) scoreTexts[i].text = players[i].Score.ToString();

        }
    }
}

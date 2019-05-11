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
            O2Tank o2Tank = players[i].GetComponent<O2Tank>();
            float score = Mathf.Floor(o2Tank.CurrentO2);
            if (scoreTexts[i]) scoreTexts[i].text = score.ToString();
        }
    }
}

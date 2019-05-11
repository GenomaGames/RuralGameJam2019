using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{

    public GameObject winScreen;
    public Text winText;

    public void ShowWinScreen (string winnerName) {
        winText.text = "Player " + winnerName + " Wins!";
        winScreen.SetActive(true);
    }
}

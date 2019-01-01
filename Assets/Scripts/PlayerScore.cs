using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour {

    // Configuration parameters
    [SerializeField] int playerScore;
    [SerializeField] int pointsPerBlock = 10;
    [SerializeField] TextMeshProUGUI playerScoreString;

    // Called from Block script
    public void AddPoints () 
    {
        playerScore = playerScore + pointsPerBlock;
        playerScoreString.text = playerScore.ToString();
    }
}
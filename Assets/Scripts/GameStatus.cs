using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour {

    // Configuration parameters
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlock = 10;
    [SerializeField] TextMeshProUGUI scoreText;

    // State variables
    [SerializeField] int playerScore = 0;

	// Use this for initialization
	void Start () 
    {
        scoreText.text = playerScore.ToString();
    }

    // Update is called once per frame
    void Update () 
    {
        Time.timeScale = gameSpeed;
	}

    public void AddPoints()
    {
        playerScore += pointsPerBlock;
        scoreText.text = playerScore.ToString();
    }
}
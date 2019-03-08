using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour {

    // Configuration parameters
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlock = 10;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI livesText;
    //[SerializeField] TextMeshProUGUI xerienText;

    // State variables
    [SerializeField] int playerScore = 0;
    [SerializeField] public static int playerLives = 3;
    //[SerializeField] int xerienScore = 0;

    private void Awake ()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1) 
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else 
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start () 
    {
        scoreText.text = playerScore.ToString();
        livesText.text = playerLives.ToString(playerLives + " Lives");
        //xerienText.text = xerienScore.ToString(xerienScore + " Xerienstones");
    }

    void Update () 
    {
        Time.timeScale = gameSpeed;
	}

    public void AddPoints ()
    {
        playerScore += pointsPerBlock;
        scoreText.text = playerScore.ToString();
    }

    public void AddLife ()
    {
        playerLives += 1;
        livesText.text = playerLives.ToString(playerLives + " Lives");
    }

    /* public void AddXerien()
    {
        if (playerScore == 10) 
        {
            xerienScore += 1;
        }

        xerienText.text = xerienScore.ToString(xerienScore + " Xerienstones");
    } */

    public void RemoveLife ()
    {
        playerLives -= 1;
        livesText.text = playerLives.ToString(playerLives + " Lives");
    }

    public void ResetScore ()
    {
        Destroy(gameObject);
    }

    public void ResetLives ()
    {
        playerLives = 3;
    }
}
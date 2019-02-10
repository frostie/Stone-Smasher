using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameSession.playerLives <= 0) 
        {
            FindObjectOfType<SceneLoader>().LoadGameOverScene();
        }
        else
        {
            FindObjectOfType<GameSession>().RemoveLife();
            FindObjectOfType<Ball>().ResetBallPos();
        }
    }
}
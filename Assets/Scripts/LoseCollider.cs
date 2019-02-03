using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().RemoveLife();
        FindObjectOfType<Ball>().ResetBallPos();

        /* TODO
         * When playerLives <= 0, SceneManager.LoadScene("Game Over"); 
        */
    }
}
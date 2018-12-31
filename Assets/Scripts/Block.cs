using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    // Configuration parameters

    [SerializeField] AudioClip breakSound;

    // Cached references
    Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>(); // Accesses the Level class
        level.CountBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject);
        FindObjectOfType<Level>(); // Accesses the Level class

    }
}
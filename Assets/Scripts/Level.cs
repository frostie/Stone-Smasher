using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    // Configuration parameters
    [SerializeField] int breakableBlocks; // Serialized for debugging purposes

    // Cached references
    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>(); // Accesses the SceneLoader class
    }

    public void CountBreakableBlocks() 
    {
        breakableBlocks++;
    }

    public void BlockDestroyed() 
    {
        breakableBlocks--;
        if (breakableBlocks <= 0) 
        {
            sceneloader.LoadNextScene();
        }
    }
}
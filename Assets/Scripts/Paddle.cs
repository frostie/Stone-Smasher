using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    // Configuration Parameters
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1.28f;
    [SerializeField] float maxX = 14.71f;

	void Start () 
    {
		
	}
	
	public void Update () 
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(mousePosInUnits, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        transform.position = paddlePos;
	}
}
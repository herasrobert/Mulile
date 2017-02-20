﻿using UnityEngine;
using System.Collections;

public class PipeFlowerControllerScript : MonoBehaviour {
	//float delayTimer = 0f;
	//public float maxDelayTimer = 0f;
	public float movementSpeed = 0f;
	float startingPosition = 0f;	
	float endingPosition = 0f;

	bool movingUp = true;

	void Start(){
		endingPosition = this.transform.position.y; // Get Up Y Position
		transform.position = new Vector2 (transform.position.x, transform.position.y - 1f); // Move Plant Down 1 Square so its "in" pipe
		startingPosition = this.transform.position.y; // Get Down Y Position
	}

	void Update(){
		if (movingUp){
			transform.Translate(Vector3.up * movementSpeed);//Move Up
			if(transform.position.y > endingPosition){ // If we went high enough
				movingUp = false;
			}
		} else {
			transform.Translate(Vector3.up * movementSpeed * -1);//Move Down
			if(transform.position.y < startingPosition){//If we went too low
				movingUp = true;
			}
		}
	}


}

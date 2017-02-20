using UnityEngine;
using System.Collections;

public class ReboundPlatformController : MonoBehaviour {
	public float movementSpeed = 3f;

	public bool horizontal;	
	bool rebound = false;

	SpriteRenderer roundPlatformRenderer;
	
	public Sprite horizontalPlatform;
	public Sprite verticalPlatform;

	void Start(){
		roundPlatformRenderer = this.GetComponent<SpriteRenderer>();
		
		if (horizontal){ 
			roundPlatformRenderer.sprite = horizontalPlatform;
		} else { //Vertical
			roundPlatformRenderer.sprite = verticalPlatform;
		}
	}
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag != "Player"){
			toggleRebound();
		}
	}
	void Update(){
		if (horizontal) {
			horizontalMovement();
		} else {
			verticalMovement();
		}
	}
	void horizontalMovement(){
		if (rebound == false) {
			this.transform.Translate (Vector2.right * movementSpeed * Time.deltaTime);
			//transform.localScale = new Vector3 (1, 1, 1);
		} else {
			this.transform.Translate (-Vector2.right * movementSpeed * Time.deltaTime);
			//transform.localScale = new Vector3 (-1, 1, 1);
		}
	}
	
	void verticalMovement(){
		if (rebound == false) {
			this.transform.Translate (Vector2.up * movementSpeed * Time.deltaTime); // Move Up
			//transform.localScale = new Vector3 (1, 1, 1);
		} else {
			this.transform.Translate (-Vector2.up * movementSpeed * Time.deltaTime); // Move Down
			//transform.localScale = new Vector3 (1, -1, 1);
		}
	}

	void toggleRebound(){
		if (rebound) {
			rebound = false;
		} else {
			rebound = true;
		}
	}
}

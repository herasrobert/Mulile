using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {

	float movementSpeed = 3f;

	public Sprite cloudOne;
	public Sprite cloudTwo;
	public Sprite cloudThree;
	public Sprite cloudFour;
	public Sprite cloudFive;
	public Sprite cloudSix;
	public Sprite cloudSeven;
	GameObject player;
	Rigidbody2D body;
	SpriteRenderer spriteRenderer;

	float distance = 0f;
	float maxDistance = -15f;

	void Start () {
		spriteRenderer = this.GetComponent<SpriteRenderer>();
		body = this.GetComponent<Rigidbody2D>();
		player = GameObject.Find("Player");


		randomSprite();
		randomSpeed();
	}


	void Update () {
		body.velocity = new Vector2 (-movementSpeed, body.velocity.y);

		distance = this.transform.position.x - player.transform.position.x;
		if(distance < maxDistance){
			this.transform.position = new Vector2(player.transform.position.x+20f, this.transform.position.y);//Reposition
			randomSprite();
			randomSpeed();
		}
	}


	void randomSprite(){
		int randomSprite = (int) Random.Range (0f,7f);

		if(randomSprite == 0){
			spriteRenderer.sprite = cloudOne;
		}else if(randomSprite == 1){
			spriteRenderer.sprite = cloudTwo;
		}else if(randomSprite == 2){
			spriteRenderer.sprite = cloudThree;
		}else if(randomSprite == 3){
			spriteRenderer.sprite = cloudFour;			
		}else if(randomSprite == 4){
			spriteRenderer.sprite = cloudFive;			
		}else if(randomSprite == 5){
			spriteRenderer.sprite = cloudSix;			
		}else if(randomSprite == 6){
			spriteRenderer.sprite = cloudSeven;			
		}
	}

	void randomSpeed(){
		int randomSpeed = (int) Random.Range (3f, 7f);
		movementSpeed = randomSpeed;
	}

}
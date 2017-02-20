using UnityEngine;
using System.Collections;

public class FireballColorScript : MonoBehaviour {

	public Sprite fireBall;
	public Sprite blueFireball;
	public Sprite purpleFireBall;
	public Sprite yellowFireBall;
	public Sprite orangeFireBall;

	SpriteRenderer spriteRenderer;
	void Start(){
		spriteRenderer = this.GetComponent<SpriteRenderer>();

		int randomNumber = (int) Random.Range (0f,5f);

		if(randomNumber == 0){
			//Do Nothing
		}else if(randomNumber == 1){
			spriteRenderer.sprite = blueFireball;
		}else if(randomNumber == 2){
			spriteRenderer.sprite = purpleFireBall;
		}else if(randomNumber == 3){
			spriteRenderer.sprite = yellowFireBall;
		}else if(randomNumber == 4){
			spriteRenderer.sprite = orangeFireBall;
		}
	}

	void Update(){
	
	}
}

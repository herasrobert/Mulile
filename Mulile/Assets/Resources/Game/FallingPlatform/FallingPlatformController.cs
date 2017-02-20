using UnityEngine;
using System.Collections;

public class FallingPlatformController : MonoBehaviour {
	public float fallingSpeed = 3f;
	public float delayBeforeFall = .2f;

	//Rigidbody2D body;

	bool fall = false;
	void Start () {
		//body = this.GetComponent<Rigidbody2D>();	
	}

	void Update(){
		if(fall){
			delayBeforeFall -= Time.deltaTime;
			if(delayBeforeFall < 0){
				this.transform.Translate (-Vector2.up * fallingSpeed * Time.deltaTime); // Move Down
			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			//body.isKinematic = false;
			fall = true;
		}
	}
}

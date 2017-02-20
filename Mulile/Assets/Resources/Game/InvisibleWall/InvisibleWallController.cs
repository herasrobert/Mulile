using UnityEngine;
using System.Collections;

public class InvisibleWallController : MonoBehaviour {

	SpriteRenderer spriteRenderer;
	void Start () {
		spriteRenderer = this.GetComponent<SpriteRenderer>();

		spriteRenderer.enabled = false; //Turn "Invisible"
	}

	void Update(){}	

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player"){
			spriteRenderer.enabled = true;
		}
	}
}

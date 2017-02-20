using UnityEngine;
using System.Collections;

public class OneWayWallController : MonoBehaviour {

	SpriteRenderer spriteRenderer;
	BoxCollider2D boxCollider;

	void Start(){
		spriteRenderer = this.GetComponent<SpriteRenderer>();
		boxCollider = this.GetComponent<BoxCollider2D>();

		spriteRenderer.enabled = false;
	}

	void Update(){
	
	}

	
	void OnTriggerExit2D(Collider2D coll){
		if (coll.gameObject.tag == "Player"){
			spriteRenderer.enabled = true;
			boxCollider.isTrigger = false;
			boxCollider.size = new Vector2(1f,1f);
		}
	}


}

using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour {
	public Vector2 jumpVector;
	public bool isGrounded;
	public Transform grounder;
	public float radius;
	public LayerMask ground;

	public float movementSpeed = 50f;

	Rigidbody2D body;
	void Start(){
		body = this.GetComponent<Rigidbody2D>();
	}

	void Update(){
		PlayerMovement();
	}

	public float x = .5f;
	void PlayerMovement(){
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			body.velocity = new Vector2 (-movementSpeed, body.velocity.y);
			transform.localScale = new Vector3 (-1, 1, 1);
		} else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			body.velocity = new Vector2 (movementSpeed, body.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
		} else {
			body.velocity = new Vector2(0,body.velocity.y);
		}
		isGrounded = Physics2D.OverlapCircle (grounder.transform.position, radius, ground);

		if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
			body.AddForce (jumpVector,ForceMode2D.Force);
		}

	}

	void OnDrawGizmos(){
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere (grounder.transform.position, radius);
	}
}

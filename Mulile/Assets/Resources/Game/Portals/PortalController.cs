using UnityEngine;
using System.Collections;

public class PortalController : MonoBehaviour {

	public bool isActive;

	public GameObject entrancePortal;
	public GameObject exitPortal;
	SpriteRenderer spriteRenderer;
	
	public Sprite defaultEntrancePortal;
	public Sprite blockedEntrancePortal;
	public Sprite defaultExitPortal;
	public Sprite blockedExitPortal;

	void Start(){
		spriteRenderer = this.GetComponent<SpriteRenderer>();

		if (!isActive) {
			if(this.tag == "PortalEntrance"){
				spriteRenderer.sprite = blockedEntrancePortal;
			}else{
				spriteRenderer.sprite = blockedExitPortal;
			}
		} else {
			if(this.tag == "PortalEntrance"){
				spriteRenderer.sprite = defaultEntrancePortal;		
			}else{
				spriteRenderer.sprite = defaultExitPortal;
			}
		}

	}

	void Update(){
		if(isActive){			
			transform.Rotate(0,0,-5);
		}
	}

	void OnTriggerStay2D(Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
				if(isActive){
					if(this.tag == "PortalEntrance"){
						coll.transform.position = new Vector2(exitPortal.transform.position.x, exitPortal.transform.position.y);
					}else{
						coll.transform.position = new Vector2(entrancePortal.transform.position.x, entrancePortal.transform.position.y);
					}
				}
			}
		}
	}
}

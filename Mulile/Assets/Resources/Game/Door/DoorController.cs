using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {
	public bool isLocked;

	public int levelThisDoorLeadsTo;

	public Sprite lockedDoor;
	public Sprite door;

	GameObject levelController;
	LevelController levelControllerScript;
	SpriteRenderer doorsRenderer;

	void Start(){
		levelController = GameObject.Find ("LevelController");
		if(levelController != null){
			levelControllerScript = levelController.GetComponent<LevelController>();
		}
		doorsRenderer = this.GetComponent<SpriteRenderer>();

		if (isLocked) {
			doorsRenderer.sprite = lockedDoor;
		} else {
			doorsRenderer.sprite = door;
		}
	}

	void Update(){}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			if(!isLocked){
				if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
					levelControllerScript.setCurrentLevel(levelThisDoorLeadsTo);
					levelControllerScript.LoadLevel(levelThisDoorLeadsTo);
				}
			}
		}		
	}

	void OnTriggerStay2D(Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			if(!isLocked){
				if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
					levelControllerScript.setCurrentLevel(levelThisDoorLeadsTo);
					levelControllerScript.LoadLevel(levelThisDoorLeadsTo);
				}
			}
		}		
	}

	public void toggleLock(){
		doorsRenderer = this.GetComponent<SpriteRenderer>();
		if (isLocked) {
			isLocked = false;
			doorsRenderer.sprite = door;
		} else {
			isLocked = true;
			doorsRenderer.sprite = lockedDoor;
		}
	}
}

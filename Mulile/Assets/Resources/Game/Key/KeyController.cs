using UnityEngine;
using System.Collections;

public class KeyController : MonoBehaviour {

	public GameObject thisKeysDoor;
	DoorController doorControllerScript;

	void Start(){
		doorControllerScript = thisKeysDoor.GetComponent<DoorController>();

	}
	void Update(){
	
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player"){
			doorControllerScript.toggleLock();
			Destroy(this.gameObject);
		}
	}
}

using UnityEngine;
using System.Collections;

public class NPCController : MonoBehaviour {
	public bool runOnce = false;
	bool displayMessage = true;

	public GameObject thisNPCMessage;
	SpriteRenderer thisNPCMessageRenderer;
	void Start () {
		thisNPCMessageRenderer = thisNPCMessage.GetComponent<SpriteRenderer>();
		displayMessage = true;
	}

	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll){
		if(displayMessage){
			if (coll.gameObject.tag == "Player") {
				thisNPCMessageRenderer.enabled = true;//Display Message	
				if(runOnce){
					displayMessage = false;
				}
			}
		}


	}

	void OnTriggerExit2D(Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			thisNPCMessageRenderer.enabled = false;//Display Message		
		}
		
		
	}
}

using UnityEngine;
using System.Collections;

public class DestroyDistanceController : MonoBehaviour {

	GameObject player;
	public float destroyDistance = 35f;
	float distance = 0f;

	void Start () {
		player = GameObject.Find("Player");
	}

	void Update () {
		distance = this.transform.position.y - player.transform.position.y;
		if(distance < destroyDistance){
			Destroy(this.gameObject);
		}
	}

}

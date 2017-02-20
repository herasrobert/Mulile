using UnityEngine;
using System.Collections;

public class FallingBoulderSpawner : MonoBehaviour {

	float timer = 0f;
	public bool spawn = true;
	public float maxTimer = 0f;
	public GameObject fallingBoulder;
	Vector2 thisObjectsPosition;

	void Start () {
		thisObjectsPosition = new Vector2(this.transform.position.x, this.transform.position.y);
	}

	void Update () {
		if(spawn){
			timer -= Time.deltaTime;
			if(timer < 0){
				Instantiate(fallingBoulder, thisObjectsPosition, Quaternion.identity);//Spawn Boulder
				timer = maxTimer;
			}
		}
	}
}

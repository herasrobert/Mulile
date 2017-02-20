using UnityEngine;
using System.Collections;

public class FadeOutController : MonoBehaviour {

	float timer = 0f;
	public float waitTime = 0.0f;
	float fadeCounter = 1f;
	bool fadeOut;
	bool run = true;
	SpriteRenderer spriteRenderer;

	void Start() {
		spriteRenderer = this.GetComponent<SpriteRenderer>();
		
		run = true;
		fadeOut = false;
		timer = waitTime;
	}
	void Update() {
		if (run){
			timer -= Time.deltaTime;

			if (timer < 0) {
				fadeOut = true;
			}
			if (fadeOut) {
				fadeCounter -= Time.deltaTime;
				spriteRenderer.color = new Color (1f, 1f, 1f, fadeCounter);

				if (fadeCounter < 0) {
					//Destroy (this.gameObject);
					run = false;
				}
			}
		}
	}
}

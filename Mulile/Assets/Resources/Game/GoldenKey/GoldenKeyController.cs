using UnityEngine;
using System.Collections;

public class GoldenKeyController : MonoBehaviour {
	public bool worldOneKey = false;
	public bool worldTwoKey = false;
	public bool worldThreeKey = false;

	public bool worldOneDisplayKey = false;
	public bool worldTwoDisplayKey = false;
	public bool worldThreeDisplayKey = false;

	int unlocked = 0;

	SpriteRenderer spriteRenderer;

	void Start(){		
		spriteRenderer = this.GetComponent<SpriteRenderer>();

		if(worldOneDisplayKey){
			if(PlayerPrefs.HasKey("WorldOneKeyUnlocked")){
				unlocked = PlayerPrefs.GetInt("WorldOneKeyUnlocked");
			}else {
				unlocked = 0;
				PlayerPrefs.SetInt("WorldOneKeyUnlocked", unlocked);
			}
		}else if(worldTwoDisplayKey){
			if(PlayerPrefs.HasKey("WorldTwoKeyUnlocked")){
				unlocked = PlayerPrefs.GetInt("WorldTwoKeyUnlocked");
			}else {
				unlocked = 0;
				PlayerPrefs.SetInt("WorldTwoKeyUnlocked", unlocked);
			}
		}else if(worldThreeDisplayKey){
			if(PlayerPrefs.HasKey("WorldThreeKeyUnlocked")){
				unlocked = PlayerPrefs.GetInt("WorldThreeKeyUnlocked");
			}else {
				unlocked = 0;
				PlayerPrefs.SetInt("WorldThreeKeyUnlocked", unlocked);
			}
		}

		if(unlocked == 1){
			spriteRenderer.enabled = true;
		}

	}

	void Update(){}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player"){
			if(worldOneKey){
				PlayerPrefs.SetInt("WorldOneKeyUnlocked", 1);
			}else if(worldTwoKey){
				if(worldTwoKey){
					PlayerPrefs.SetInt("WorldTwoKeyUnlocked", 1);
				}
			}else if(worldThreeKey){
				PlayerPrefs.SetInt("WorldThreeKeyUnlocked", 1);
			}
			
			Destroy(this.gameObject);
		}	
	}
}

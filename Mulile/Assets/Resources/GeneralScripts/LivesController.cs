using UnityEngine;
using System.Collections;

public class LivesController : MonoBehaviour {

	int currentLives = 0;

	void Awake(){		
		DontDestroyOnLoad (transform.gameObject);
		
		if (FindObjectsOfType (GetType ()).Length > 1) {// Prevent Duplicated of this GameObject due to DontDestroyOnLoad
			Destroy (gameObject);
		}
	}

	void Start(){
		if (PlayerPrefs.HasKey ("Lives")) {
			currentLives = PlayerPrefs.GetInt ("Lives");
		} else {
			currentLives = 10;
			PlayerPrefs.SetInt("Lives", currentLives);
		}

	}

	void Update(){
	
	}

	public int getCurrentLives(){
		return currentLives;
	}
	public void addLives(){
		currentLives++;
	}
	public void addLives(int amount){		
		currentLives+= amount;
	}
	public void subtractLives(){
		currentLives--;		
	}
	public void subtractLives(int amount){
		currentLives-= amount;		
	}
	public void resetLives(){
		currentLives = 10;
		PlayerPrefs.SetInt("Lives", currentLives);
	}


}

using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {
	int currentGoldCoins = 0;

	void Awake(){		
		DontDestroyOnLoad (transform.gameObject);
		
		if (FindObjectsOfType (GetType ()).Length > 1) {// Prevent Duplicated of this GameObject due to DontDestroyOnLoad
			Destroy (gameObject);
		}
	}

	void Start(){
		if (PlayerPrefs.HasKey ("GoldCoins")) {
			currentGoldCoins = PlayerPrefs.GetInt("GoldCoins");
		} else {
			currentGoldCoins = 0;
			PlayerPrefs.SetInt("GoldCoins", currentGoldCoins);
		}
	}

	void Update(){
	
	}

	public void addGoldCoin(){
		currentGoldCoins++;
	}
	public void addGoldCoin(int amount){
		currentGoldCoins += amount;	
	}
	public int getGoldCoins(){
		return currentGoldCoins;
	}
}

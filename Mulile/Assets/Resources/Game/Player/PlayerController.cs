using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	GameObject livesController;
	LivesController livesControllerScript;
	GameObject levelController;
	LevelController levelControllerScript;
	GameObject coinController;
	CoinController coinControllerScript;

	/*void Awake(){		
		DontDestroyOnLoad (transform.gameObject);
		
		if (FindObjectsOfType (GetType ()).Length > 1) {// Prevent Duplicated of this GameObject due to DontDestroyOnLoad
			Destroy (gameObject);
		}
	}*/

	void Start(){
		livesController = GameObject.Find ("LivesController");
		if(livesController != null){			
			livesControllerScript = livesController.GetComponent<LivesController>();
		}
		levelController = GameObject.Find ("LevelController");
		if(levelController != null){
			levelControllerScript = levelController.GetComponent<LevelController>();
		}
		coinController = GameObject.Find ("CoinController");
		if(coinController != null){
			coinControllerScript = coinController.GetComponent<CoinController>();
		}
	}

	void Update(){	

		DebugTools();
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Spikes"){
			dead();//Dead
		}
		if (coll.gameObject.tag == "DeathZone"){
			dead();//Dead
		}
		if (coll.gameObject.tag == "ToxicFloor"){
			dead();//Dead
		}
		if (coll.gameObject.tag == "MovingPlatform"){
			this.transform.parent = coll.transform;
		}
	}
	void OnCollisionExit2D(Collision2D coll){
		if (coll.gameObject.tag == "MovingPlatform"){
			transform.parent = null;
		}
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Spikes"){
			dead();//Dead
		}
		if (coll.gameObject.tag == "GoldCoin"){
			coinControllerScript.addGoldCoin();
			Destroy(coll.gameObject);
		}
		if (coll.gameObject.tag == "Fireball"){
			dead();//Dead
		}
		if (coll.gameObject.tag == "DeathZone"){
			dead();//Dead
		}
		if (coll.gameObject.tag == "Bat"){
			dead();//Dead
		}
		if (coll.gameObject.tag == "Slime"){
			dead();//Dead
		}
		if (coll.gameObject.tag == "Spinner"){
			dead();//Dead
		}
		if (coll.gameObject.tag == "PipeFlower"){
			dead();//Dead
		}
		if (coll.gameObject.tag == "FallingBoulder"){
			dead();//Dead
		}
		if (coll.gameObject.tag == "BreakableBlock"){
			Destroy(coll.gameObject);
		}
	}

	void OnTriggerExit2D(Collider2D coll){}


	
	void OnGUI(){
		if(livesControllerScript != null){
			GUI.Label(new Rect(10, 0, 100, 20), "Lives: " + livesControllerScript.getCurrentLives());
			GUI.Label(new Rect(10, 10, 100, 20), "Coins: " + coinControllerScript.getGoldCoins());
		}
	}


	void dead(){
		if (livesControllerScript.getCurrentLives () > 1) { // If 2 or More
			livesControllerScript.subtractLives();//subtract Lives			
			Application.LoadLevel(Application.loadedLevel);
		} else { // If 1, and going to be 0 because about to subtract life	
			livesControllerScript.resetLives();
			levelControllerScript.resetLevels();
			Application.LoadLevel("DeathScene");
		}
	}


	void DebugTools(){
		if(Input.GetKeyDown(KeyCode.Backspace)){
			Application.LoadLevel("MainMenu");
		}
		if(Input.GetKeyDown(KeyCode.K)){
			dead();
		}
		if(Input.GetKeyDown(KeyCode.KeypadPlus)){
			Application.LoadLevel(Application.loadedLevel+1);
		}
		if(Input.GetKeyDown(KeyCode.KeypadMinus)){
			Application.LoadLevel(Application.loadedLevel-1);
		}
		if(Input.GetKeyDown(KeyCode.Keypad8)){
			livesControllerScript.addLives();
		}
		if(Input.GetKeyDown(KeyCode.Keypad2)){
			livesControllerScript.subtractLives();
		}



	}
}

using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

	public Texture mainMenuBackground;

	GameObject livesController;
	LivesController livesControllerScript;
	GameObject levelController;
	LevelController levelControllerScript;
	
	void Start(){
		livesController = GameObject.Find ("LivesController");
		livesControllerScript = livesController.GetComponent<LivesController>();
		levelController = GameObject.Find ("LevelController");
		levelControllerScript = levelController.GetComponent<LevelController>();

		/*latestLevel = 0;
		livesController = GameObject.Find ("LivesController");		
		livesControllerScript = livesController.GetComponent<LivesController>();
		levelController = GameObject.Find ("LevelController");
		levelControllerScript = levelController.GetComponent<LevelController> ();
		
		if(PlayerPrefs.HasKey("LatestLevel")){
			latestLevel = PlayerPrefs.GetInt("LatestLevel");
		}
		
		if(livesControllerScript.getCurrentLives() == 0){
			livesControllerScript.clearLives();
			livesControllerScript.setcurrentLives(10);
			levelControllerScript.resetLevels();			
			latestLevel = PlayerPrefs.GetInt("LatestLevel");
		}*/
		
	}
	
	void Update(){
		
	}
	
	void OnGUI(){
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), mainMenuBackground, ScaleMode.StretchToFill);

		if(levelControllerScript.getCurrentLevel() > 1){		
			if (GUI.Button (new Rect (150, 10, 100, 50), "Continue")){
				levelControllerScript.loadLatestLevel();
			}
		}
		
		if (GUI.Button (new Rect (10, 10, 100, 50), "Play")) {
			Application.LoadLevel("InstructionsScene");
		}

		if (GUI.Button (new Rect (300, 300, 100, 50), "Clear")) {
			PlayerPrefs.DeleteAll();
			levelControllerScript.resetLevels();
			livesControllerScript.resetLives();
			Start();
		}
		
		
	}
}

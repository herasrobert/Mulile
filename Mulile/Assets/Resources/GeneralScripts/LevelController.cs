using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {
	int currentLevel = 0;

	void Awake(){		
		DontDestroyOnLoad (transform.gameObject);
		
		if (FindObjectsOfType (GetType ()).Length > 1) {// Prevent Duplicated of this GameObject due to DontDestroyOnLoad
			Destroy (gameObject);
		}
	}

	void Start(){
		if (PlayerPrefs.HasKey ("Levels")) {
			currentLevel = PlayerPrefs.GetInt ("Levels");
		} else {
			currentLevel = 1;
			PlayerPrefs.SetInt("Levels", currentLevel);
		}
	}

	void Update(){
	
	}

	public int getCurrentLevel(){
		return currentLevel;
	}

	public void resetLevels(){
		currentLevel = 1;
		PlayerPrefs.SetInt("Levels", currentLevel);
	}
	public void loadLatestLevel(){
		if(currentLevel == 0){
			Application.LoadLevel ("MainMenu");
		}else if (currentLevel == 1) {
			Application.LoadLevel ("IntroLevel");
		}else if (currentLevel == 2){
			Application.LoadLevel("WorldSelect");		
		}else if (currentLevel == 3){
			Application.LoadLevel("WorldOneRoomOne");		
		}else if (currentLevel == 4){
			Application.LoadLevel("WorldOneRoomTwo");		
		}else if (currentLevel == 5){
			Application.LoadLevel("WorldOneRoomThree");		
		}else if (currentLevel == 6){
			Application.LoadLevel("WorldOneRoomFour");		
		}else if (currentLevel == 7){
			Application.LoadLevel("WorldOneRoomFive");		
		}else if (currentLevel == 8){
			Application.LoadLevel("WorldOneRoomSix");		
		}else if (currentLevel == 9){
			Application.LoadLevel("WorldOneRoomSeven");		
		}else if (currentLevel == 10){
			Application.LoadLevel("WorldOneRoomEight");		
		}else if (currentLevel == 11){
			Application.LoadLevel("WorldOneRoomNine");		
		}else if (currentLevel == 12){
			Application.LoadLevel("WorldOneRoomTen");		
		}else if (currentLevel == 13){
			Application.LoadLevel("WorldOneRoomEleven");		
		}else if (currentLevel == 14){
			Application.LoadLevel("WorldOneRoomTwelve");		
		}else if (currentLevel == 15){
			Application.LoadLevel("WorldOneRoomThirteen");		
		}else if (currentLevel == 16){
			Application.LoadLevel("WorldOneRoomFourteen");		
		}else if (currentLevel == 17){
			Application.LoadLevel("WorldOneRoomFifteen");		
		}else if (currentLevel == 18){
			Application.LoadLevel("WorldOneRoomSixteen");		
		}else if (currentLevel == 50){
			Application.LoadLevel("WorldTwoRoomOne");		
		}else if (currentLevel == 51){
			Application.LoadLevel("WorldTwoRoomTwo");		
		}else if (currentLevel == 52){
			Application.LoadLevel("WorldTwoRoomThree");		
		}else if (currentLevel == 53){
			Application.LoadLevel("WorldTwoRoomFour");		
		}else if (currentLevel == 54){
			Application.LoadLevel("WorldTwoRoomFive");		
		}else if (currentLevel == 55){
			Application.LoadLevel("WorldTwoRoomSix");		
		}else if (currentLevel == 56){
			Application.LoadLevel("WorldTwoRoomSeven");		
		}else if (currentLevel == 57){
			Application.LoadLevel("WorldTwoRoomEight");		
		}else if (currentLevel == 58){
			Application.LoadLevel("WorldTwoRoomNine");		
		}
	}
	public void setCurrentLevel(int level){
		currentLevel = level;
		PlayerPrefs.SetInt("Levels", currentLevel);
	}
	public void LoadLevel(int Level){
		if(currentLevel == 0){
			Application.LoadLevel ("MainMenu");
		}else if (currentLevel == 1) {
			Application.LoadLevel ("IntroLevel");
		}else if (currentLevel == 2) {
			Application.LoadLevel("WorldSelect");		
		}else if (currentLevel == 3){
			Application.LoadLevel("WorldOneRoomOne");		
		}else if (currentLevel == 4){
			Application.LoadLevel("WorldOneRoomTwo");		
		}else if (currentLevel == 5){
			Application.LoadLevel("WorldOneRoomThree");		
		}else if (currentLevel == 6){
			Application.LoadLevel("WorldOneRoomFour");		
		}else if (currentLevel == 7){
			Application.LoadLevel("WorldOneRoomFive");		
		}else if (currentLevel == 8){
			Application.LoadLevel("WorldOneRoomSix");		
		}else if (currentLevel == 9){
			Application.LoadLevel("WorldOneRoomSeven");		
		}else if (currentLevel == 10){
			Application.LoadLevel("WorldOneRoomEight");		
		}else if (currentLevel == 11){
			Application.LoadLevel("WorldOneRoomNine");		
		}else if (currentLevel == 12){
			Application.LoadLevel("WorldOneRoomTen");		
		}else if (currentLevel == 13){
			Application.LoadLevel("WorldOneRoomEleven");		
		}else if (currentLevel == 14){
			Application.LoadLevel("WorldOneRoomTwelve");		
		}else if (currentLevel == 15){
			Application.LoadLevel("WorldOneRoomThirteen");		
		}else if (currentLevel == 16){
			Application.LoadLevel("WorldOneRoomFourteen");		
		}else if (currentLevel == 17){
			Application.LoadLevel("WorldOneRoomFifteen");		
		}else if (currentLevel == 18){
			Application.LoadLevel("WorldOneRoomSixteen");		
		}else if (currentLevel == 50){
			Application.LoadLevel("WorldTwoRoomOne");		
		}else if (currentLevel == 51){
			Application.LoadLevel("WorldTwoRoomTwo");		
		}else if (currentLevel == 52){
			Application.LoadLevel("WorldTwoRoomThree");		
		}else if (currentLevel == 53){
			Application.LoadLevel("WorldTwoRoomFour");		
		}else if (currentLevel == 54){
			Application.LoadLevel("WorldTwoRoomFive");		
		}else if (currentLevel == 55){
			Application.LoadLevel("WorldTwoRoomSix");		
		}else if (currentLevel == 56){
			Application.LoadLevel("WorldTwoRoomSeven");		
		}else if (currentLevel == 57){
			Application.LoadLevel("WorldTwoRoomEight");		
		}else if (currentLevel == 58){
			Application.LoadLevel("WorldTwoRoomNine");		
		}
	}
}

using UnityEngine;
using System.Collections;

public class DeathSceneController : MonoBehaviour {
	
	public Texture deathSceneBackground;

	void Start(){
	
	}

	void Update(){
	
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), deathSceneBackground, ScaleMode.StretchToFill);

		if (GUI.Button (new Rect (10, 10, 100, 50), "Main Menu")) {
			Application.LoadLevel("MainMenu");
		}


	}
}

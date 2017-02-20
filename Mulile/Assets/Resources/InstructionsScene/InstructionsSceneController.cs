using UnityEngine;
using System.Collections;

public class InstructionsSceneController : MonoBehaviour {
	
	public Texture instructionsSceneBackground;

	void Start(){
	
	}


	void Update(){
	
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), instructionsSceneBackground, ScaleMode.StretchToFill);

		if (GUI.Button (new Rect (10, 10, 100, 50), "Play")) {
			Application.LoadLevel("IntroLevel");
		}

	}
}

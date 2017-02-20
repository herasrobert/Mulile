using UnityEngine;
using System.Collections;

public class StudioSplashScreenController : MonoBehaviour {

	
	public Texture studioSplashScreenBackground;

	void Start(){
		Application.LoadLevel("MainMenu");
	}


	void Update(){
	
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), studioSplashScreenBackground, ScaleMode.StretchToFill);
	}

}

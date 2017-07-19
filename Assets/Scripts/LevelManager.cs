using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;

	void Start (){
		if (autoLoadNextLevelAfter == 0) {
			Debug.Log ("Level auto load disabled");
			} else {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
			} 
	}

	public void LoadLevel(string name){
		Debug.Log ("Level Load Requested for: " + name);
		Application.LoadLevel(name); 
	}

	public void QuitRequest(){
		Debug.Log ("Player would like to quit");
		Application.Quit();
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}


}

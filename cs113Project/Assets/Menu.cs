using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		//Create the menu box
		GUI.Box(new Rect(550,80,250,300),"Metal Wars");
		
		//Create the Start button
		if(GUI.Button(new Rect(625,150,100,50),"Start")) {
			Debug.Log("StartButton pressed.");
			Application.LoadLevel("Scene1");
		}
		
		//Create the Options button
		if(GUI.Button(new Rect(625,210,100,50),"Options")) {
			Debug.Log("OptionsButton pressed.");
		}
		
		//Create the Credits button
		if(GUI.Button(new Rect(625,270,100,50),"Credits")) {
			Debug.Log("CreditsButton pressed.");
		}
	}
}

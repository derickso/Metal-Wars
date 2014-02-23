using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public Texture2D menuLogo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUI.DrawTexture (new Rect(Screen.width/3.5f, Screen.height/10f - 10, 400, 250), menuLogo);

		//Create the menu box
		GUI.BeginGroup (new Rect (Screen.width / 3f, Screen.height / 3.5f, 250, 300));
			//GUI.Box(new Rect(0,0,250,250),"Metal Wars");
			
			//Create the Start button
			if(GUI.Button(new Rect(75,70,100,50),"Start")) {
				Debug.Log("StartButton pressed.");
				Application.LoadLevel("Scene1");
			}
			
			//Create the Options button
			if(GUI.Button(new Rect(75,130,100,50),"Options")) {
				Debug.Log("OptionsButton pressed.");
			}
			
			//Create the Credits button
			if(GUI.Button(new Rect(75,190,100,50),"Credits")) {
				Debug.Log("CreditsButton pressed.");
			}
		GUI.EndGroup();
	}
}

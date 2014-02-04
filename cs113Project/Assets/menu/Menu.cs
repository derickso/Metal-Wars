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
		GUI.Box(new Rect(550,80,250,300),"Metal Wars");

		if(GUI.Button(new Rect(625,150,100,50),"Start")) {
			Application.LoadLevel("Scene1");
			Debug.Log("LoadLevel");
		}

		if(GUI.Button(new Rect(625,210,100,50),"Options")) {
			
		}

		if(GUI.Button(new Rect(625,270,100,50),"Credits")) {
			
		}
	}

}

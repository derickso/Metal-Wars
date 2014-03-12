using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {

	//Cutscenes
	public Texture sketch1;
	public Texture sketch2;


	//Subtitles
	public Texture c1;
	public Texture c2;
	public Texture c3;
	public Texture c4;
	public Texture c5;
	public Texture c6;
	public Texture c7;
	public Texture c8;
	public Texture c9;
	public Texture c10;
	public Texture c11;
	public Texture c12;
	public Texture c13;
	public Texture c14;
	public Texture c15;

	public Rect rect;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnGUI()
	{
		rect = new Rect(0.0f, 0.0f, Screen.width, Screen.height);

		if(GUI.Button(new Rect(75,70,100,50),"Skip Intro")) {
			Debug.Log("SkipButton pressed.");
			Application.LoadLevel("Scene1");
		}


		//GUI.DrawTexture (rect, sketch2);






	}

}

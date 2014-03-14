using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public Texture2D menuLogo;
	public Texture2D menuLogoText;

	public static float damageModifier;
	public static float healthModifier;

	private bool inOptions;
	private int selGridInt;
	private float hSliderValue;

	string[] descriptions;

	private AudioClip sMenuTheme;

	string[] selStrings;

	// Use this for initialization
	void Start () {
		damageModifier = 1;
		inOptions = false;
		selGridInt = 1;
		hSliderValue = 100f;
		audio.Play ();

		selStrings = new string[] {"Frost", "Normal"};
		descriptions = new string[]{ "Description 1", "Description 2", "Description 3", "Description 4" };
	}
	
	// Update is called once per frame
	void Update () {
		audio.volume = hSliderValue / 100;
	}

	void OnGUI () {
		GUI.DrawTexture (new Rect(Screen.width / 2f - 200, Screen.height/10f - 10, 400, 250), menuLogo);
		GUI.DrawTexture (new Rect(Screen.width / 2f - 200, Screen.height/10f + 210, 1400, 80), menuLogoText);

		if (!inOptions)
		{
			//Create the menu box
			GUI.BeginGroup (new Rect (Screen.width / 2f - 125, Screen.height / 3.0f, 250, 300));
				//GUI.Box(new Rect(0,0,250,250),"Metal Wars");
				
				//Create the Start button
				if(GUI.Button(new Rect(75,70,100,50),"Start")) {
					Debug.Log("StartButton pressed.");
					//Application.LoadLevel("Scene1");
					Application.LoadLevel("Intro");
				}
				
				//Create the Options button
				if(GUI.Button(new Rect(75,130,100,50),"Options")) {
					inOptions = true;
				}
				
				//Create the Credits button
				if(GUI.Button(new Rect(75,190,100,50),"Credits")) {
					Debug.Log("CreditsButton pressed.");
				}
			GUI.EndGroup();
		}

		if(inOptions)
		{
			//menuX = Screen.width / 2.5f;
			//menuY = Screen.height / 2.5f;
			
			GUI.BeginGroup (new Rect (Screen.width / 2f - 125, Screen.height / 2.3f, 250, 300));
				GUI.Box(new Rect(0,0,220,150),"Options");
				GUI.Label (new Rect (8,40, 100, 20), "Volume Control");
				hSliderValue = GUI.HorizontalSlider (new Rect (110,45, 100, 30), hSliderValue, 0.0f, 30.0f);

				GUI.Label (new Rect (8,70, 100, 20), "Difficulty");
				selGridInt = GUI.SelectionGrid (new Rect (110,73, 65, 60), selGridInt, selStrings, 1);

				if (selGridInt == 1)
				{
					damageModifier = 1f;
					healthModifier = 1f;
				}
				else if (selGridInt == 0) 
				{
					damageModifier = .25f;
					healthModifier = 2f;
				}
				
				if(GUI.Button(new Rect(60,150,100,40),"Back")) {
					inOptions = false;
				}
			GUI.EndGroup();
		}
	}
}

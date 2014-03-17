using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public Texture2D menuLogo;
	public Texture2D menuLogoText;
	public Texture2D menuWallpaper;

	public static float damageModifier;
	public static float healthModifier;

	private bool inOptions;
	private int selGridInt;
	private float hSliderValue;

	string[] descriptions;

	private AudioClip sMenuTheme;

	public GUISkin menuSkin;

	GUIContent[] customGUI = new GUIContent[2];
	string[] selStrings;

	public static float musicVolume;

	private GUIStyle GUICustom;

	// Use this for initialization
	void Start () {
		damageModifier = 1f;
		healthModifier = 1f;
		inOptions = false;
		selGridInt = 1;
		hSliderValue = 50f;
		audio.Play ();

		customGUI[0] = new GUIContent ("Frost", "Player health: 2x \nPlayer damage: 2x \n# of EMPs: Unlimited");
		customGUI [1] = new GUIContent ("Normal", "Player health: 1x \nPlayer damage: 1x \n# of EMPs: 5");
		selStrings = new string[] {"Frost", "Normal"};
	}
	
	// Update is called once per frame
	void Update () {
		musicVolume = hSliderValue / 100;
		audio.volume = musicVolume;
	}

	void OnGUI () {
		GUI.skin = menuSkin;
		GUI.DrawTexture (new Rect(0, 0, Screen.width, Screen.height), menuWallpaper);
		//GUI.BeginGroup (new Rect (Screen.width / 2f - 200, 30, 400, 350));
		//GUI.BeginGroup (new Rect (Screen.width / 3, 30, Screen.width / 2.5f, Screen.height / 2));
		GUI.BeginGroup (new Rect (Screen.width / 3.5f, 30, Screen.width, Screen.height / 2));
			GUI.DrawTexture (new Rect(-10, 0, Screen.width / 2f, Screen.height / 3.5f), menuLogo);
			//GUI.DrawTexture (new Rect(Screen.width / 25f, Screen.height / 4.5f - 10, Screen.width / 1.2f, 60), menuLogoText);
		GUI.EndGroup ();

		if (!inOptions)
		{
			//Create the menu box
			GUI.BeginGroup (new Rect (Screen.width / 2f - 125, Screen.height / 3.0f, 250, 300));
				//GUI.Box(new Rect(65,60,120,190),"");
				
				//Create the Start button
				if(GUI.Button(new Rect(75,70,100,50),"Start")) {
					//Debug.Log("StartButton pressed.");
					//Application.LoadLevel("Scene1");
					Application.LoadLevel("Intro");
				}
				
				//Create the Options button
				if(GUI.Button(new Rect(75,130,100,50),"Options")) {
					inOptions = true;
				}
				
				//Create the Credits button
				if(GUI.Button(new Rect(75,190,100,50),"Credits")) {
					//Debug.Log("CreditsButton pressed.");
				}
			GUI.EndGroup();
		}

		if(inOptions)
		{
			//menuX = Screen.width / 2.5f;
			//menuY = Screen.height / 2.5f;
			
			GUI.BeginGroup (new Rect (Screen.width / 2f - 125, Screen.height / 2.3f, 250, 300));
				GUI.Box(new Rect(0,0,220,150),"Options");
				GUI.Label (new Rect (8,40, 100, 20), "Music Volume");
				hSliderValue = GUI.HorizontalSlider (new Rect (110,45, 100, 30), hSliderValue, 0.0f, 50.0f);

				GUI.Label (new Rect (8,70, 100, 20), "Difficulty");
			//GUI.skin.button.onHover.textColor = Color.cyan;
				selGridInt = GUI.SelectionGrid (new Rect (110,73, 65, 60), selGridInt, customGUI, 1);

				if (selGridInt == 0)
				{
					damageModifier = .25f;
					healthModifier = 2f;
				}
				else if (selGridInt == 1) 
				{
					damageModifier = 1f;
					healthModifier = 1f;
				}
				
				if(GUI.Button(new Rect(60,150,100,40),"Back")) {
					inOptions = false;
				}
			GUI.EndGroup();
		}
		if (GUI.tooltip != "") {
			
			GUI.Box(new Rect (Screen.width / 2f - 200, Screen.height / 2.3f + 210, 370, 70), GUI.tooltip);
			
		}
	}
}

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





	//____________________

	private bool inTexture1 = false;
	private bool inTexture2 = false;




	private bool inC1 = false;
	private bool inC2 = false;

	private bool inC3 = false;
	private bool inC4 = false;

	private bool inC5 = false;

	private bool inC6 = false;
	private bool inC7 = false;
	private bool inC8 = false;
	private bool inC9 = false;
	private bool inC10 = false;
	private bool inC11 = false;
	private bool inC12 = false;
	private bool inC13 = false;
	private bool inC14 = false;
	private bool inC15 = false;


	//private bool  buttonPressed;
	private bool nextButton;





	public Rect rect;


	// Use this for initialization
	void Start () {
	
		inTexture1 = true;//initialize what you want to run in the game loop first

		inC1 = true;//initialize what you want to run in the game loop first
		//Basic initialization to make how the update function starts off.  <--You know this!!!!


		//
		//buttonPressed = false;
		nextButton = false;


		//Don't know if need this
		inC2 = false;
		inC3 = false;
		inC4 = false;
		inC5 = false;



	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Works exactly like Update function.  Updates every frame.  
	void OnGUI()
	{
		rect = new Rect(0.0f, 0.0f, Screen.width, Screen.height);//box gets recreated every frame
		//in order to use in conditions below.  


		if(inC1 == true)
		{

			GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c1);


			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");

		}

		if(nextButton) 
		{
			inC1 = false;
			inC2 = true;


			//
			//buttonPressed = false;
			nextButton = false;

		}





		if(inC2 == true)
		{
			GUI.DrawTexture (rect, sketch2);
			GUI.DrawTexture (rect, c2);


			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
		}

		if(nextButton)
		{
			inC2 = false;
			inC3 = true;

			//buttonPressed = false;
			nextButton = false;


		}





		if(inC3 == true)
		{
			//GUI.DrawTexture (rect, sketch2);
			GUI.DrawTexture (rect, c3);
			
			
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
		}
		
		if(nextButton)
		{
			inC3 = false;
			inC4 = true;
			
			//buttonPressed = false;
			nextButton = false;
			
			
		}





		if(inC4 == true)
		{

			GUI.DrawTexture (rect, c4);
			
			
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
		}
		
		if(nextButton)
		{
			inC4 = false;
			inC5 = true;
			
			//buttonPressed = false;
			nextButton = false;
			
			
		}





		if(inC5 == true)
		{
			
			GUI.DrawTexture (rect, c5);
			
			
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
		}
		
		if(nextButton)
		{
			inC5 = false;
			inC6 = true;
			
			//buttonPressed = false;
			nextButton = false;
			
			
		}







		if(inC6 == true)
		{
			
			GUI.DrawTexture (rect, c6);
			
			
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
		}
		
		if(nextButton)
		{
			inC6 = false;
			inC7 = true;
			
			//buttonPressed = false;
			nextButton = false;
			
			
		}







		if(inC7 == true)
		{
			
			GUI.DrawTexture (rect, c7);
			
			
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
		}
		
		if(nextButton)
		{
			inC7 = false;
			inC8 = true;
			
			//buttonPressed = false;
			nextButton = false;
			
			
		}






		if(inC8 == true)
		{
			
			GUI.DrawTexture (rect, c8);
			
			
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
		}
		
		if(nextButton)
		{
			inC8 = false;
			inC9 = true;
			
			//buttonPressed = false;
			nextButton = false;
			
			
		}







		if(inC9 == true)
		{
			
			GUI.DrawTexture (rect, c9);
			
			
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
		}
		
		if(nextButton)
		{
			inC9 = false;
			inC10 = true;
			
			//buttonPressed = false;
			nextButton = false;
			
			
		}








		if(inC10 == true)
		{
			
			GUI.DrawTexture (rect, c10);
			
			
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
		}
		
		if(nextButton)
		{
			inC10 = false;
			inC11 = true;
			
			//buttonPressed = false;
			nextButton = false;
			
			
		}









		if(inC11 == true)
		{
			
			GUI.DrawTexture (rect, c11);
			
			
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
		}
		
		if(nextButton)
		{
			inC11 = false;
			inC12 = true;

			Application.LoadLevel("Scene1");

			
			//buttonPressed = false;
			nextButton = false;
			
			
		}
















	}




	//Algorithm Above:  
	//Every frame, check to see if the _cutscene_ to execute/draw is enabled.  
	
	//1.  If that certain _cutscene_ is enabled, execute/draw the contents for that condition.
	//		also draw the button (which is a void function that returns a bool)
	
	//2.  After you do so, also check if _condition 2_ (in this case, the button) is executed/pressed.  
	//if the button is pressed (meaning that if the draw button code above executed)
	//			enable the conditions for the next set cutscene textures to be allowed
	
	//Back to 1.  <----This looping idea.  <---Hence why you duplicate 1. and 2. for EVERY transitioning to 
	//to the next set of cutscenes (things to execute)
	
	//eg)
	//1. if(cutscene 1 enabled)run cutscene1
	//2. if(pressed) enable cutscene 2
	
	//1. if(cutscene 2 enabled) run cutscene 2
	//2. if(pressed) enable cutscene 3
	
	//1.  if(cutscene 3 enabled)......





}

using UnityEngine;
using System.Collections;

using System.Net;

public class Player : MonoBehaviour {


	public GameObject target = null;//Camera

	//public float field1 = 3.0f;
	//public bool field2 = true;
	
	//int privateField = 3;

	//private Transform player;
	//public int playerSpeed = 20;

	public float rotateSpeed = 25.0f;
	public float speed = 50.0f;
	//public float speed = 10.0f;

	//private float landingSpeed = 

	public GameObject enemyTarget;//temporary enemy target for time being

	
	private int armor, lives;

	public float menuX = 0.0f;
	public float menuY = 0.0f;

	private bool isPaused;
	private bool inOptions;
	
	public float hSliderValue = 15.0f;
	
	int selGridInt  = 0;
	string[] selStrings = new string[] {"Easy", "Medium", "Hard"};

	public Vector2 healthBarPos = new Vector2(20,40);	
	public Vector2 healthBarSize = new Vector2(90,20);
	public Texture2D emptyTex;
	public Texture2D fullTex;
	public Texture2D missIcon;
	public static double numMissiles = 5;
	public float healthAmount;


	//Default thrusters
	public ParticleSystem defaultThrust1;
	public ParticleSystem defaultThrust2;

	//Afterburners
	public ParticleSystem thruster1;
	public ParticleSystem thruster2;

	//Slow down thrusters
	public ParticleSystem engineHeat1;
	public ParticleSystem engineHeat2;




	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		//Things to set up how the beginning of the scene should be, goes HERE.  
		//What to do right at the beginning of the scene.  
		//If attached, it is object instead of scene.  

		//player = transform;  //Pointing saves space!!!!!  //eg) Input playerInputs; playerInputs = Input;  ....YOU GET THE IDEA!!!! 

		//Move object into scene
		//player.position = new Vector3(0, 5, 0);
		transform.position = new Vector3(0,15,0);
		transform.Rotate(0,0,0);
		transform.localScale.Scale(new Vector3(1,1,1));


		defaultThrust1.enableEmission = false;
		defaultThrust2.enableEmission = false;
		thruster1.enableEmission = false;
		thruster2.enableEmission = false;
		engineHeat1.enableEmission = false;
		engineHeat2.enableEmission = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		healthAmount = .75f;



		//__________Ace Combat_______

		float transAmount = speed * Time.deltaTime;
		float rotateAmount = rotateSpeed * Time.deltaTime;



		transform.Translate(0,0,transAmount);



		defaultThrust1.enableEmission = true;
		defaultThrust2.enableEmission = true;

		thruster1.enableEmission = false;
		thruster2.enableEmission = false;

		engineHeat1.enableEmission = true;
		engineHeat2.enableEmission = true;



		//pitch
		if(Input.GetKey (KeyCode.UpArrow))
		{
			transform.Rotate (rotateAmount, 0, 0);
			//target.transform.localPosition = transform.position + new Vector3(0,0,-7);


			//camera rotate down along x
			//target.transform.Rotate(transform.rotation.x,0,0);//Code that caused problem.  Camera collision fixed
			//Although, that commented out code above had the strange attribute of causing 
			//the cube not to be centered all the time, making the fighter more "realistic".  
			//Come back to this if have more time.  For now, it stays fixed.  


		}
		if(Input.GetKey (KeyCode.DownArrow))
		{
			transform.Rotate (-rotateAmount, 0, 0);
			//target.transform.localPosition = transform.position + new Vector3(0,0,-7);

			//camera rotate up along x
			//target.transform.Rotate (-transform.rotation.x,0,0);//Code that caused problem.  Camera collision fixed
			//Although, that commented out code above had the strange attribute of causing 
			//the cube not to be centered all the time, making the fighter more "realistic".  
			//Come back to this if have more time.  For now, it stays fixed.  



		}

		//yaw
		if(Input.GetKey (KeyCode.A))
		{
			transform.Rotate (0, -rotateAmount, 0);
		}
		if(Input.GetKey (KeyCode.D))
		{
			transform.Rotate (0, rotateAmount, 0);
		}


		//barrel roll left
		if(Input.GetKey (KeyCode.LeftArrow))
		{
			transform.Rotate (0, 0, (rotateAmount * 2));
		}

		//barrel roll right
		if(Input.GetKey (KeyCode.RightArrow))
		{
			transform.Rotate (0, 0, (-rotateAmount * 2));
		}

		//speed up
		if(Input.GetKey (KeyCode.W))
		{
			transform.Translate (0, 0, transAmount * 2);


			engineHeat1.enableEmission = false;
			engineHeat2.enableEmission = false;

			thruster1.enableEmission = true;
			thruster2.enableEmission = true;
		}

		//slow down
		if(Input.GetKey (KeyCode.S))
		{
			transform.Translate (0, 0, (-transAmount * 0.5f) );//Does slow down


			defaultThrust1.enableEmission = false;
			defaultThrust2.enableEmission = false;

			engineHeat1.enableEmission = true;
			engineHeat2.enableEmission = true;

			thruster1.enableEmission = false;
			thruster2.enableEmission = false;
		}

		//Follow enemy plane
		if(Input.GetKey (KeyCode.RightShift))
		{
			transform.LookAt (enemyTarget.transform.position);
			//transform.Translate (
		}

		

		//Finish later
		//Landing/Takeoff
		/*if(Input.GetKey ("t"))
		{
			transform.Translate(0, transform.position.y - 1,transAmount);
		}*/

		//If the player hits the keyCode.P, it will change the pause state of the game
		if(Input.GetKeyDown (KeyCode.P))
		{
			ChangePause();
		}
	}
	
	//Pause function: changes between states (paused and unpaused)
	protected void ChangePause() {
		//Pause the game
		if(isPaused)
			Time.timeScale = 1;
		//Unpause the game
		else
			Time.timeScale = 0;
		//Change the boolean variable accordingly
		isPaused = !isPaused;
	}
	
	void OnGUI (){
		//draw the background:
		GUI.Label(new Rect (healthBarPos.x, healthBarPos.y - 23, 100, 20), "Health");
		GUI.BeginGroup(new Rect(healthBarPos.x, healthBarPos.y, healthBarSize.x, healthBarSize.y));
			GUI.Box(new Rect(0,0, healthBarSize.x, healthBarSize.y), emptyTex);
		
			//draw the filled-in part:
			GUI.BeginGroup(new Rect(0,0, healthBarSize.x * healthAmount, healthBarSize.y));
				GUI.DrawTexture(new Rect(0,0, healthBarSize.x * healthAmount, healthBarSize.y), fullTex);
			GUI.EndGroup();
		GUI.EndGroup();

		int offset = 22;
		int missileWidth = 15;
		//GUI.BeginGroup(new Rect(healthBarPos.x, healthBarPos.y + 34, healthBarSize.x, healthBarSize.y));
		for (int i = 0; i < numMissiles; i++)
		{
			GUI.DrawTexture (new Rect (healthBarPos.x + i*offset, 60, missileWidth, 35), missIcon, ScaleMode.ScaleToFit);
		}
		//GUI.EndGroup();


		if(isPaused && !inOptions)
		{
			menuX = Screen.width/2.5f;
			menuY = Screen.height/2.5f;

			GUI.Box(new Rect(menuX,menuY,220,180),"Paused");
			
			//Create the Start button
			if(GUI.Button(new Rect(menuX + 60,menuY + 30,100,40),"Resume")) {
				Debug.Log("Resume");
				ChangePause();
			}
			if(GUI.Button(new Rect(menuX + 60,menuY + 80,100,40),"Options")) {
				inOptions = true;
				Debug.Log ("Options");
				//OnGUI();
			}
			if(GUI.Button(new Rect(menuX + 60,menuY + 130,100,40),"Main Menu")) {
				Debug.Log("Quit to Main Menu");
				Application.LoadLevel("Menu");
			}
		}
		if(inOptions && isPaused)
		{
			menuX = Screen.width / 2.5f;
			menuY = Screen.height / 2.5f;
			
			GUI.Box(new Rect(menuX,menuY, 220, 200),"Options");
			
			GUI.Label (new Rect (menuX +8,menuY + 40, 100, 20), "Volume Control");
			hSliderValue = GUI.HorizontalSlider (new Rect (menuX + 110,menuY + 45, 100, 30), hSliderValue, 0.0f, 30.0f);
			
			GUI.Label (new Rect (menuX +8,menuY + 70, 100, 20), "Difficulty");
			selStrings = new string[] {"Easy", "Medium", "Hard"};
			selGridInt = GUI.SelectionGrid (new Rect (menuX + 110,menuY + 73, 65, 60), selGridInt, selStrings, 1);
			
			if(GUI.Button(new Rect(menuX + 60,menuY + 150,100,40),"Back")) {
				Debug.Log("Exit Options");
				inOptions = false;
			}
		}
	}
}

using UnityEngine;
using System.Collections;

using System.Net;

public class Player : MonoBehaviour {

	public GameObject explosion;
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

	private float angleToBackBounds = 0;
	private bool outOfBounds = false;

	private int score;
	private float armor, maxArmor;

	public float menuX = 0.0f;
	public float menuY = 0.0f;

	private bool isPaused;
	private bool inOptions;
	private bool isGameOver;
	public static bool isDead;

	public AudioClip sPlayerExplosion;

	public float hSliderValue = 15.0f;
	
	int selGridInt  = 0;
	string[] selStrings = new string[] {"Easy", "Medium", "Hard"};

	public Vector2 healthBarPos = new Vector2(20,40);	
	public Vector2 healthBarSize = new Vector2(90,20);
	public Texture2D emptyTex;
	public Texture2D fullTex;
	public Texture2D empIcon;
	public Texture2D livesIcon;
	public Texture2D thirdCrosshair;
	public static double numEMPs;
	public static double numLives = 3;
	public static float healthAmount;
	public GUIStyle scoreFont;
	public Font digitalFont;

	public static float rotateAmount;

	//Default thrusters
	public ParticleSystem defaultThrust1;
	public ParticleSystem defaultThrust2;

	//Afterburners
	public ParticleSystem thruster1;
	public ParticleSystem thruster2;

	//Slow down thrusters
	public ParticleSystem engineHeat1;
	public ParticleSystem engineHeat2;


	//Sounds
	public AudioClip sPlayerImpact;


	//EMP Playing
	public ParticleSystem EMPCore;
	public ParticleSystem EMP1;
	public ParticleSystem EMP2;
	public ParticleSystem EMP3;


	public float empCountDown;

	public bool empEnabled = true;



	//Player Explosion
	public ParticleSystem playerExplosion;

	//LowHealthDamage
	public ParticleSystem lowHealthDamage1;
	public ParticleSystem lowHealthDamage2;



	// Use this for initialization
	void Start () {
		outOfBounds = false;
		scoreFont = new GUIStyle();
		scoreFont.font = digitalFont;
		scoreFont.fontSize = 24;
		scoreFont.normal.textColor = Color.yellow;
		scoreFont.alignment = TextAnchor.MiddleRight;

		score = 0;
		maxArmor = armor = 50.0f;


		isGameOver = false;
		isDead = false;
		numEMPs = 5;
		//numLives = 3;
		Time.timeScale = 1;
		healthAmount = 1.0f;
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



		EMPCore.enableEmission = false;
		EMP1.enableEmission = false;
		EMP2.enableEmission = false;
		EMP3.enableEmission = false;

		playerExplosion.enableEmission = false;


		lowHealthDamage1.enableEmission = false;
		lowHealthDamage2.enableEmission = false;


		empCountDown = 0.0f;
		
	}
	
	// Update is called once per frame
	void Update () {


		float transAmount = speed * Time.deltaTime;//Do not delete.  
		//float rotateAmount = rotateSpeed * Time.deltaTime;
		transform.Translate(0,0,transAmount);//Do not delete.  



		if (healthAmount <= 0)
		{
			if (!isDead) {
				audio.Stop ();
				audio.PlayOneShot (sPlayerExplosion, 0.3F);
			}
			isDead = true;
			//audio.Stop ();
			speed = 0;
			defaultThrust1.Stop ();
			defaultThrust2.Stop ();
			thruster1.Stop ();
			thruster2.Stop ();
			engineHeat1.Stop ();
			engineHeat2.Stop ();
			GameObject[] targets = GameObject.FindGameObjectsWithTag("PlayerModel");
			foreach (GameObject Target in targets) {
				Target.renderer.enabled = false;
			}
			Invoke("Explode", 1.4f);
		}
		//if (numLives <= 0)
		//{
		//	isGameOver = true;
		//}

		//__________Ace Combat_______


		//Debug.Log("out "+outOfBounds);
		if(outOfBounds)
			returnToMapBounds();
		else
			receiveInputCommands();
	}

	public void Explode() {
		if (!isGameOver)
			numLives--;
		//StartCoroutine(Lose());
		Time.timeScale = 0;
		isGameOver = true;
	}

	//Procedure to make the player go back to the map bounds
	protected void returnToMapBounds(){
		//Calculates the translation and rotation amounts
		float transAmount = 0.5f* speed * Time.deltaTime;

		if(angleToBackBounds < 1)
			transform.Translate(0,0,transAmount);
		else{
			float returnRotateAmount = 3f* rotateSpeed * Time.deltaTime;

			if(returnRotateAmount<angleToBackBounds){
				angleToBackBounds -= returnRotateAmount;
				transform.Rotate (-returnRotateAmount, 0, 0);
			}else{
				transform.Rotate(-angleToBackBounds, 0, 0);
				angleToBackBounds = 0;
			}
		}
	}

	//Receives the player inputs and make their procedures
	protected void receiveInputCommands () {

		//Calculates the translation and rotation amounts
		float transAmount = speed * Time.deltaTime;
		rotateAmount = rotateSpeed * Time.deltaTime;

		//transform.Translate(0,0,transAmount);


		//Sets the particle systems defaults
		normalSpeedMode();


		//Disable EMP while it's not fired
		empActivated (false);
		EMPCore.enableEmission = false;
		EMP1.enableEmission = false;
		EMP2.enableEmission = false;
		EMP3.enableEmission = false;



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
			transform.Rotate (0, 0, (rotateAmount * 1));
		}
		
		//barrel roll right
		if(Input.GetKey (KeyCode.RightArrow))
		{
			transform.Rotate (0, 0, (-rotateAmount * 1));
		}
		
		//speed up
		if(Input.GetKey (KeyCode.W))
		{
			transform.Translate (0, 0, transAmount * 2);

			fastSpeedMode();
		}
		
		//slow down
		if(Input.GetKey (KeyCode.S))
		{
			transform.Translate (0, 0, (-transAmount * 0.5f) );//Does slow down

			slowSpeedMode();
		}
		
		//Follow enemy plane
		//if(Input.GetKey (KeyCode.RightShift))
		//{
		//	transform.LookAt (enemyTarget.transform.position);
		//	//transform.Translate (
		//}

		empEnabled = true;

		//Fire EMP
		if(Input.GetKey (KeyCode.E) && (numEMPs >= 0) && (empEnabled == true))
		{
			empActivated (true);

			//Destroy (GameObject.FindWithTag("Enemy"));
			//if(PlayerView.numOfEnemiesLeft == 0) numEMPs--;
			//GameObject.FindGameObjectWithTag("Enemy").gameObject.GetComponent ("Enemy");
			//Enemy enemy = (Enemy)otherObject.gameObject.GetComponent("Enemy");

			//Enemy enemy = (Enemy)gameObject.GetComponent("Enemy");
			//enemy.receiveDamage(30);

			//GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
			//Enemy

			//Timer so EMP can't be held down.  EMP stops emitting after a press period
			//And the key is allowed to be pressed again.  
			empCountDown += Time.deltaTime;
			if(empCountDown >= 0.05f)
			{
				empActivated (false);
				empCountDown = 0.0f;//Crucial to reset the counter. Otherwise this condition will
				//always be met, causing empActivated to keep executing.  

				//numEMPs--;
				empEnabled = false;
			}



		}
		if(Input.GetKeyDown (KeyCode.E) && (numEMPs >= 0))
		{
			numEMPs--;
		}


		//Testing player damage:
		//if(Input.GetKeyDown (KeyCode.K))
		//{
		//	armor = 10.0f;
		//}


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

	//Set the particle system of the engine and the thrust to match the normal speed mode
	protected void normalSpeedMode(){
		if (!isDead) {
			defaultThrust1.enableEmission = true;
			defaultThrust2.enableEmission = true;
			
			thruster1.enableEmission = false;
			thruster2.enableEmission = false;
			
			engineHeat1.enableEmission = true;
			engineHeat2.enableEmission = true;
		}
	}

	//Set the particle system of the engine and the thrust to match the slow speed mode
	protected void slowSpeedMode(){
		if (!isDead) {
			defaultThrust1.enableEmission = false;
			defaultThrust2.enableEmission = false;
			
			engineHeat1.enableEmission = true;
			engineHeat2.enableEmission = true;
			
			thruster1.enableEmission = false;
			thruster2.enableEmission = false;
		}
	}

	//Set the particle system of the engine and the thrust to match the fast speed mode
	protected void fastSpeedMode(){
		if (!isDead) {
			defaultThrust1.enableEmission = true;
			defaultThrust2.enableEmission = true;

			engineHeat1.enableEmission = false;
			engineHeat2.enableEmission = false;
			
			thruster1.enableEmission = true;
			thruster2.enableEmission = true;
		}
	}

	protected void empActivated(bool activated)
	{

		if(activated == true)
		{
			EMPCore.enableEmission = true;
			EMP1.enableEmission = true;
			EMP2.enableEmission = true;
			EMP3.enableEmission = true;

		}
		else{

			EMPCore.enableEmission = false;
			EMP1.enableEmission = false;
			EMP2.enableEmission = false;
			EMP3.enableEmission = false;

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


	//Shows the user interface
	void OnGUI (){
		/*if (PlayerView.ThirdIsEnabled == true)
		{
			GUI.DrawTexture(new Rect(Screen.width/2f - 22, Screen.height/2f - 55, 45, 35), thirdCrosshair);
		}*/


		if (isGameOver)
		{
			GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
			playerObject.renderer.enabled = false;
			this.renderer.enabled = false;
			Time.timeScale = 0;
			menuX = Screen.width/2.5f;
			menuY = Screen.height/2.5f;
		
			if (numLives <= 0)
			{
				GUI.Box(new Rect(menuX,menuY,220,150),"You're finished, kid.");

				if(GUI.Button(new Rect(menuX + 60,menuY + 50,100,40),"Main Menu")) {
					numLives = 3;
					Application.LoadLevel ("Menu");
				}
			}
			else
			{
				GUI.Box(new Rect(menuX,menuY,220,150),"You died! :(");
				GUI.Label(new Rect(menuX+58,menuY+30,220,150),"Restart mission?");

				//Create the Start button
				if(GUI.Button(new Rect(menuX + 60,menuY + 50,100,40),"Yes")) {
					Time.timeScale = 1;
					Application.LoadLevel ("Scene1");
				}
				if(GUI.Button(new Rect(menuX + 60,menuY + 100,100,40),"No")) {
					Application.LoadLevel ("Menu");
				}
			}
		}
		//draw the number of lives
		GUI.Label(new Rect (healthBarPos.x, healthBarPos.y - 35, healthBarSize.x, 10), score.ToString(), scoreFont);
		GUI.Label(new Rect (healthBarPos.x, healthBarPos.y - 21, 100, 20), "Lives");
		for (int i = 0; i < numLives; i++)
		{
			GUI.DrawTexture (new Rect (healthBarPos.x + 35 + i*17, healthBarPos.y - 25, 15, 28), livesIcon, ScaleMode.ScaleToFit);
		}
		
		GUI.BeginGroup(new Rect(healthBarPos.x, healthBarPos.y, healthBarSize.x, healthBarSize.y));
			GUI.Box(new Rect(0,0, healthBarSize.x, healthBarSize.y), emptyTex);
		
			//draw the filled-in part:
			GUI.BeginGroup(new Rect(0,0, healthBarSize.x * healthAmount, healthBarSize.y));
				GUI.DrawTexture(new Rect(0,0, healthBarSize.x * healthAmount, healthBarSize.y), fullTex);
				GUI.Label(new Rect (0,0, 100, 20), "Armor");
			GUI.EndGroup();
		GUI.EndGroup();


		int empWidth = 15;
		//GUI.BeginGroup(new Rect(healthBarPos.x, healthBarPos.y + 34, healthBarSize.x, healthBarSize.y));
		for (int i = 0; i < numEMPs; i++)
		{
			GUI.DrawTexture (new Rect (healthBarPos.x + i*20, 55, empWidth, 28), empIcon, ScaleMode.ScaleToFit);
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

	//Function called to cause damage to the player
	public void receiveDamage(float damage){
		armor -= damage;
		//healthAmount = healthAmount - .125f;//health bar (the armor) goes down everytime this is called.  
		//healthAmount = healthAmount - (damage * 0.125f);
		healthAmount = armor/maxArmor;
		//Debug.Log("Player damaged!!"+damage);
		audio.PlayOneShot (sPlayerImpact);

		if(armor <= 15)
		{
			lowHealthDamage1.enableEmission = true;
			lowHealthDamage2.enableEmission = true;
		}


		if(armor < 1)
		{
			//Die procedure:
			/*
			//Create explosion HERE
			GameObject expl = (GameObject)Instantiate(explosion, transform.position, Quaternion.identity);

			--lives;
			Destroy(gameObject);
			Destroy(expl,2);
			*/
			playerExplosion.enableEmission = true;
		}
	}
	
	void OnTriggerEnter (Collider collider) {
		//if it enters the MapBounds it stop the return procedure
		if(collider.CompareTag("MapBounds"))
			outOfBounds = false;
	}

	void OnTriggerExit (Collider collider) {
		//if it gets out of the MapBounds it starts the return procedure
		if(collider.CompareTag("MapBounds")){
			outOfBounds = true;//to make the out of bounds procedure
			slowSpeedMode();
			angleToBackBounds = 180;
			//transform.Rotate(180, 0, 0);
		}
	}

	//Function used to add score to the current player
	public void addScore (int score) {
		//if the player armor is full it gains double score
		if(armor == maxArmor)
			this.score += score*2;
		//else it just receives the usual score
		else
			this.score += score;

		//Debug.Log("Score: "+this.score);
	}
}

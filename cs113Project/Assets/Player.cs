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

	private int armor, lives;

	private bool isPaused;

	// Use this for initialization
	void Start () {
		
		//Things to set up how the beginning of the scene should be, goes HERE.  
		//What to do right at the beginning of the scene.  
		//If attached, it is object instead of scene.  

		//player = transform;  //Pointing saves space!!!!!  //eg) Input playerInputs; playerInputs = Input;  ....YOU GET THE IDEA!!!! 

		//Move object into scene
		//player.position = new Vector3(0, 5, 0);
		transform.position = new Vector3(0,15,0);
		transform.Rotate(0,0,0);
		transform.localScale.Scale(new Vector3(1,1,1));

		isPaused = false;
	}
	
	// Update is called once per frame
	void Update () {
		


		//__________Ace Combat_______

		float transAmount = speed * Time.deltaTime;
		float rotateAmount = rotateSpeed * Time.deltaTime;


		//transform.Translate(0,0,transAmount);


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
		if(Input.GetKey (KeyCode.LeftArrow))
		{
			transform.Rotate (0, -rotateAmount, 0);
		}
		if(Input.GetKey (KeyCode.RightArrow))
		{
			transform.Rotate (0, rotateAmount, 0);
		}


		//barrel roll left
		if(Input.GetKey (KeyCode.A))
		{
			transform.Rotate (0, 0, (rotateAmount * 2));
		}

		//barrel roll right
		if(Input.GetKey (KeyCode.D))
		{
			transform.Rotate (0, 0, (-rotateAmount * 2));
		}

		//forward
		if(Input.GetKey (KeyCode.W))
		{
			transform.Translate (0, 0, transAmount * 2);
		}

		//backward
		if(Input.GetKey (KeyCode.S))
		{
			transform.Translate (0, 0, (transAmount * 0.03f) );//Does not slow down...
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
		if(isPaused)
		{
			GUI.Box(new Rect(550,100,200,70),"Paused");
			
			//Create the Start button
			if(GUI.Button(new Rect(600,120,100,40),"Resume")) {
				Debug.Log("Resume");
				ChangePause();
			}
		}
	}
}

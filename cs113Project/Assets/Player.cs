using UnityEngine;
using System.Collections;

using System.Net;

public class Player : MonoBehaviour {
	
	
	//public float field1 = 3.0f;
	//public bool field2 = true;
	
	//int privateField = 3;

	//private Transform player;
	//public int playerSpeed = 20;

	public float rotateSpeed = 25.0f;
	public float speed = 50.0f;


	
	// Use this for initialization
	void Start () {
		
		//Things to set up how the beginning of the scene should be, goes HERE.  
		//What to do right at the beginning of the scene.  
		//If attached, it is object instead of scene.  

		//player = transform;  //Pointing saves space!!!!!  //eg) Input playerInputs; playerInputs = Input;  ....YOU GET THE IDEA!!!! 

		//Move object into scene
		//player.position = new Vector3(0, 5, 0);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//Things that keep running in a loop and constant checking of scene's state, goes HERE.  
		//Code that executes while scene is already active.  
		
		
		//if(field2)
		//	transform.Rotate(new Vector3(field1,0,0));

		//Clock (The Real Time);  NECESSARY.  Run based on real time instead of game's speed
		//* modifies, so * this to whatever movement, shooting, etc, you are doing.  


		//HOW to move attached object around:  

		//Move player left and right

		//player.Translate (Vector3.right * Input.GetAxis ("Horizontal"));//Found "Horizontal" by going to File, Project Settings, Input
		//player.Translate(Vector3.right * Input.GetAxis ("Horizontal") * playerSpeed * Time.deltaTime);
		//Under project settings is a func/class you can call. 

		//Move player up and down

		//player.Translate (Vector3.up * Input.GetAxis ("Vertical"));
		//player.Translate(Vector3.up * Input.GetAxis ("Vertical") * playerSpeed * Time.deltaTime);

		//Just use linear algebra and CS stuff instead of this (This is backup):
		//* means at the same time//* is to modify the _____ on far left (ex) ____ * modification )
		//... * modification <----'modification' modifies entire thing before previously.  Recursion. 
		//+ means "also do this"; ____ +____+_____ ..... :
		// _____ after that do _______ after that do ______ .... Calc and Linear Algebra, remember?


		//Input.   <----Input manager// SEE?!?!? Assign to built in objects, Just like C++.  
		//Input i = Input; ....

		/*
		//Make the player wrap:
		//ex)  If the player positions at end of screen (ex) +7, 0, 0), then the player shows up at other side (ex) -7, 0, 0)
		//y and z do not change for this game.  
		//if(player.position.x > camera.aspect * 2)
		//	player.position.x = -camera.collider * 2;
		//else if(player.position.x < -camera.aspect * 2)
		//	player.position.x = camera.aspect * 2;
		//Just hard code it.  See the height and width of your camera object by simply inspecting it. 
		//Use the int values given to the height and width of the view box
		//and then use that number here!  
		*/

		//Make the player wrap:
		//ex)  If the player positions at end of screen (ex) +7, 0, 0), then the player shows up at other side (ex) -7, 0, 0)
		//y and z do not change for this game.  

		//if(player.position.x > 


		//__________Ace Combat_______

		float transAmount = speed * Time.deltaTime;
		float rotateAmount = rotateSpeed * Time.deltaTime;



		//pitch
		if(Input.GetKey ("up"))
		{
			transform.Rotate (rotateAmount, 0, 0);
		}
		if(Input.GetKey ("down"))
		{
			transform.Rotate (-rotateAmount, 0, 0);
		}

		//yaw
		if(Input.GetKey ("left"))
		{
			transform.Rotate (0, -rotateAmount, 0);
		}
		if(Input.GetKey ("right"))
		{
			transform.Rotate (0, rotateAmount, 0);
		}


		//barrel roll left
		if(Input.GetKey ("x"))
		{
			transform.Rotate (0, 0, rotateAmount);
		}

		//barrel roll right
		if(Input.GetKey ("z"))
		{
			transform.Rotate (0, 0, -rotateAmount);
		}

		//boost
		if(Input.GetKey ("a"))
		{
			transform.Translate (0, 0, transAmount);
		}

		//slow down
		if(Input.GetKey ("q"))
		{
			transform.Translate (0, 0, (transAmount * 2));
		}
		










		
	}
}

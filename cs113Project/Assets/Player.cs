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
		
	}
	
	// Update is called once per frame
	void Update () {
		


		//__________Ace Combat_______

		float transAmount = speed * Time.deltaTime;
		float rotateAmount = rotateSpeed * Time.deltaTime;


		transform.Translate(0,0,transAmount);


		//pitch
		if(Input.GetKey ("up"))
		{
			transform.Rotate (rotateAmount, 0, 0);
			//target.transform.localPosition = transform.position + new Vector3(0,0,-7);


			//camera rotate down along x
			//target.transform.Rotate(transform.rotation.x,0,0);//Code that caused problem.  Camera collision fixed
			//Although, that commented out code above had the strange attribute of causing 
			//the cube not to be centered all the time, making the fighter more "realistic".  
			//Come back to this if have more time.  For now, it stays fixed.  


		}
		if(Input.GetKey ("down"))
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
		//if(Input.GetKey ("left"))
		if(Input.GetKey ("a"))
		{
			transform.Rotate (0, -rotateAmount, 0);
		}
		//if(Input.GetKey ("right"))
		if(Input.GetKey ("d"))
		{
			transform.Rotate (0, rotateAmount, 0);
		}


		//barrel roll left
		if(Input.GetKey ("left"))
		//if(Input.GetKey ("a"))
		{
			transform.Rotate (0, 0, (rotateAmount * 2));
		}

		//barrel roll right
		if(Input.GetKey ("right"))
		//if(Input.GetKey ("d"))
		{
			transform.Rotate (0, 0, (-rotateAmount * 2));
		}

		//forward
		if(Input.GetKey ("w"))
		{
			transform.Translate (0, 0, transAmount * 2);
		}

		//backward
		if(Input.GetKey ("s"))
		{
			transform.Translate (0, 0, (transAmount * 0.003f) );//Does not slow down...
		}
		

		//Finish later
		//Landing/Takeoff
		/*if(Input.GetKey ("t"))
		{
			transform.Translate(0, transform.position.y - 1,transAmount);
		}*/







		
	}
}

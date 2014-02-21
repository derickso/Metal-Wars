using UnityEngine;
using System.Collections;

public class HeavyPlane : Enemy {

	//Speeds
	public float rotateSpeed;
	private const float speed = 60.0f;
	
	//Enemy armor
	//private int armor;
	
	// Use this for initialization
	void Start () {
		
		rotateSpeed = Random.Range(50,70);
		
		//Just to give a little turn
		transform.Rotate (0, 0, 20);
		
		if(Random.Range(0,1)==0)
			//Makes it follows not straight paths
			transform.Rotate (0, 0, Random.Range(0, 20));
		
		armor = 60;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Calculating the scout speed and its rotation
		float transAmount = speed * Time.deltaTime;
		float rotateAmount = rotateSpeed * Time.deltaTime;
		
		//Unturns it
		transform.Rotate (0, 0, -20);
		//Goes forward and rotates in a circle
		transform.Translate(0,0,-transAmount);//Needs to be -transAmount because the model is backwards
		transform.Rotate (0, rotateAmount, 0);
		//Turns it a little to give the impression of being turning
		transform.Rotate (0, 0, 20);
		
	}
}

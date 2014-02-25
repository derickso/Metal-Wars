using UnityEngine;
using System.Collections;


public abstract class Enemy : MonoBehaviour {

	public GameObject explosion;
	protected int armor;

	public bool isDestroyed;//public because var is not part of the object
	//Don't know if we can inherit.  Assume not.  So we need to make the object before accessing
	//this.  But even so, we make it public so that it won't be destroyed along with the object...
	//That's the idea for now....
	//Must set to false in the EnemySpawner.cs

	//Speeds
	public float rotateSpeed;
	protected float speed;

	//Paths
	protected const int PATH_CIRCLE = 1;
	protected const int PATH_EIGHT 	= 2;
	private int path;

	private float eightRotated;
	private bool eightPathCircle;

	/*
	// Use this for initialization
	//Initializer, ALL the variables must be initialized here
	void Start () {
		armor = 50;
		
		speed = 50.0f;
		rotateSpeed = 50.0f;
		
		path = PATH_CIRCLE;

		//Initialize variabes
		startInit();
		//Initialize the path way
		startInitPath();
	}

	//Initializer, ALL the variables must be initialized here
	protected abstract void startInit () {}
	*/

	//Initializer, ALL the variables must be initialized here
	protected void startInit () {
		armor = 50;
		
		speed = 50.0f;
		rotateSpeed = 50.0f;
		
		setPath(PATH_CIRCLE);
	}

	//Init procedure for each path
	protected void startInitPath () {

		switch(path)//Depending on the chosen path
		{
		case PATH_CIRCLE:
			//Just to give a little turn
			transform.Rotate (0, 0, -20);
			
			if(Random.Range(0,1)==0)
				//Makes it follows not straight paths
				transform.Rotate (0, 0, Random.Range(-20, 20));
			break;

		case PATH_EIGHT:
			//Just to give a little turn
			//transform.Rotate (0, 0, -20);
			
			if(Random.Range(0,1)==0)
				//Makes it follows not straight paths
				transform.Rotate (0, 0, Random.Range(-20, 20));

			eightRotated = 360.0f;
			eightPathCircle = false;
			break;

		default:
			break;
		}
	}

	// Update is called once per frame
	void Update () {

		switch(path)
		{
		case PATH_CIRCLE:
			moveInCircle();
			break;
		case PATH_EIGHT:
			moveInEight();
			break;
		default:
			break;
		}
	}

	//Called when hitted, procedure to receive damage
	public void receiveDamage(int damage) {
	//public bool receiveDamage(int damage) {


		isDestroyed = false;//Make this false at the beginning.  Only change it to true if 
		//game object is destroyed
		//Must be initialized
		//set to false every time this is called


		armor -= damage;
		//Debug.Log("Enemy Damaged!! "+armor);
		if(armor < 1)
		{
			GameObject expl = (GameObject)Instantiate(explosion, transform.position, Quaternion.identity);
			//Create explosion HERE
			Destroy(expl,2);
			Destroy(gameObject);
			isDestroyed = true;
		}


	}






	//Follows the circle path
	protected void moveInCircle () {
		//Calculating the scout speed and its rotation
		float transAmount = speed * Time.deltaTime;
		float rotateAmount = rotateSpeed * Time.deltaTime;
		
		//Unturns it
		transform.Rotate (0, 0, 20);
		//Goes forward and rotates in a circle
		transform.Translate(0,0,transAmount);//Needs to be -transAmount because the model is backwards
		transform.Rotate (0, rotateAmount, 0);
		//Turns it a little to give the impression of being turning
		transform.Rotate (0, 0, -20);
	}

	//The opposite circle path
	private void moveInAntiCircle () {
		//Calculating the scout speed and its rotation
		float transAmount = speed * Time.deltaTime;
		float rotateAmount = rotateSpeed * Time.deltaTime;
		
		//Unturns it
		transform.Rotate (0, 0, -20);
		//Goes forward and rotates in a circle
		transform.Translate(0,0,transAmount);//Needs to be -transAmount because the model is backwards
		transform.Rotate (0, -rotateAmount, 0);
		//Turns it a little to give the impression of being turning
		transform.Rotate (0, 0, 20);
	}

	//Moves in eight
	protected void moveInEight () {
		if(eightRotated < 1)
		{
			eightPathCircle = !eightPathCircle;
			eightRotated = 360.0f;
		}

		eightRotated -= rotateSpeed * Time.deltaTime;

		if(eightPathCircle)
			moveInCircle();
		else
			moveInAntiCircle();
	}


	//Set the enemy path type
	public void setPath (int path) {
		this.path = path;

		startInitPath();
	}

	//Get the enemy path type
	public int getPath () {
		return path;
	}

	/*
	//_WaypointStartScript1 and WaypointUpdateScript1 is used if a 1 is rolled
	void WaypointStartScript1 (Transform t, float rotateSpeed) {
		
		rotateSpeed = Random.Range(50,70);
		
		//Just to give a little turn
		t.Rotate (0, 0, 20);
		
		if(Random.Range(0,1)==0)
			//Makes it follows not straight paths
			t.Rotate (0, 0, Random.Range(0, 20));
		

	}
	
	// Update is called once per frame
	void WaypointUpdateScript1 (Transform t, float speed, float rotateSpeed) {

		//Calculating the scout speed and its rotation
		float transAmount = speed * Time.deltaTime;
		float rotateAmount = rotateSpeed * Time.deltaTime;
		
		//Unturns it
		t.Rotate (0, 0, -20);
		//Goes forward and rotates in a circle
		t.Translate(0,0,-transAmount);//Needs to be -transAmount because the model is backwards
		t.Rotate (0, rotateAmount, 0);
		//Turns it a little to give the impression of being turning
		t.Rotate (0, 0, 20);
		
	}

	//_WaypointStartScript2 and WaypointUpdateScript2 is used if a 2 is rolled

	void WaypointStartScript2 (Transform t, float rotateSpeed) {}

	void WaypointUpdateScript2 (Transform t, float speed, float rotateSpeed) {}

	//_WaypointStartScript3 and WaypointUpdateScript3 is used if a 3 is rolled

	void WaypointStartScript3 (Transform t, float rotateSpeed) {}
	
	void WaypointUpdateScript3 (Transform t, float speed, float rotateSpeed) {}

	//_WaypointStartScript4 and WaypointUpdateScript1 is used if a 4 is rolled

	void WaypointStartScript4 (Transform t, float rotateSpeed) {}
	
	void WaypointUpdateScript4 (Transform t, float speed, float rotateSpeed) {}
	*/
	
}

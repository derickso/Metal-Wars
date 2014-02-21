using UnityEngine;
using System.Collections;

public abstract class Enemy : MonoBehaviour {

	public GameObject explosion;
	protected int armor;
	
	public void receiveDamage(int damage){
		armor -= damage;
		//Debug.Log("Enemy Damaged!! "+armor);
		if(armor < 1)
		{
			GameObject expl = (GameObject)Instantiate(explosion, transform.position, Quaternion.identity);
			//Create explosion HERE
			Destroy(gameObject);
			Destroy(expl,2);
		}
	}


	//_WaypointStartScript1 and WaypointUpdateScript1 is used if a 1 is rolled

	void WaypointStartScript1 (Transform t, float rotateSpeed = 0) {
		
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






	//_WaypointStartScript3 and WaypointUpdateScript3 is used if a 3 is rolled






	//_WaypointStartScript4 and WaypointUpdateScript1 is used if a 4 is rolled






}

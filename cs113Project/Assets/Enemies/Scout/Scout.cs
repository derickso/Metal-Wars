using UnityEngine;
using System.Collections;

public class Scout : MonoBehaviour {

	//Speeds
	public float rotateSpeed;
	private const float speed = 60.0f;

	//Enemy armor
	private int armor;

	// Use this for initialization
	void Start () {

		rotateSpeed = Random.Range(50,70);

		armor = 60;

		transform.Rotate (0, 0, 20);
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

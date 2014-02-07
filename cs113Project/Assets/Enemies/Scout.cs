using UnityEngine;
using System.Collections;

public class Scout : MonoBehaviour {

	//Speeds
	public float rotateSpeed = 70.0f;
	public float speed = 60.0f;

	//Enemy armor
	private int armor;

	// Use this for initialization
	void Start () {
		armor = 60;

		transform.Rotate (0, 0, 20);
	}
	
	// Update is called once per frame
	void Update () {

		//Calculating the scout speed and its rotation
		float transAmount = speed * Time.deltaTime;
		float rotateAmount = rotateSpeed * Time.deltaTime;
		Debug.Log("rotateAmount "+rotateAmount);

		//Unturns it
		transform.Rotate (0, 0, -20);
		//Goes forward and rotates in a circle
		transform.Translate(0,0,transAmount);
		transform.Rotate (0, -rotateAmount, 0);
		//Turns it a little to give the impression of being turned
		transform.Rotate (0, 0, 20);
	}
}

using UnityEngine;
using System.Collections;

public class LightPlane : Enemy {

	//Speeds
	//public float rotateSpeed;
	//private const float speed = 60.0f;
	
	//Enemy armor
	//private int armor;
	
	// Use this for initialization
	void Start () {
		base.startInit();

		armor = 65;
		
		speed = 50.0f;
		rotateSpeed = Random.Range(50,70);
		
		setPath(PATH_CIRCLE);
	}
}

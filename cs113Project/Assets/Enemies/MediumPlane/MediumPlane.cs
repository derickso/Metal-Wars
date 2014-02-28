using UnityEngine;
using System.Collections;

public class MediumPlane : Enemy {

	//Speeds
	//public float rotateSpeed;
	//private const float speed = 60.0f;
	
	//Enemy armor
	//private int armor;
	
	// Use this for initialization
	void Start () {
		base.startInit();

		armor = 80;

		score = 250;

		speed = 40.0f;
		rotateSpeed = Random.Range(50,70);

		setPath(PATH_CIRCLE);
	}

}

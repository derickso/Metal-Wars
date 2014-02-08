﻿using UnityEngine;
using System.Collections;

public class PlayerView : MonoBehaviour {

	public Camera FirstPersonCam;
	public Camera ThirdPersonCam;

	public GameObject FirstCross;
	public GameObject ThirdCross;
	private bool viewActivated = false;


	// Use this for initialization
	void Start () {

		FirstPersonCam.enabled = false;
		ThirdPersonCam.enabled = true;

		transform.position = new Vector3(0,15.5f,-3);
		transform.Rotate (0,0,0);
		transform.localScale.Scale(new Vector3(1,1,1));
	}
	
	// Update is called once per frame
	void Update () {


		viewActivated = false;



		if(Input.GetKeyDown(KeyCode.LeftShift) && viewActivated == false)
		{
			FirstPersonCam.enabled = true;
			ThirdPersonCam.enabled = false;
			FirstCross.renderer.enabled = true;
			ThirdCross.renderer.enabled = false;

			viewActivated = true;
		}
		else if(Input.GetKeyDown(KeyCode.LeftShift) && viewActivated == true)
		{
			FirstPersonCam.enabled = false;
			ThirdPersonCam.enabled = true; 
			FirstCross.renderer.enabled = false;
			ThirdCross.renderer.enabled = true;

			viewActivated = false;
		}


	
	}
}

using UnityEngine;
using System.Collections;

using System.Net;

public class Player : MonoBehaviour {
	
	
	public float field1 = 3.0f;
	public bool field2 = true;
	
	int privateField = 3;
	
	
	// Use this for initialization
	void Start () {
		
		//Things to set up how the beginning of the scene should be, goes HERE.  
		//What to do right at the beginning of the scene.  
		//If attached, it is object instead of scene.  
		
		//Move object into scene
		transform.position = new Vector3(0, 1, 0);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//Things that keep running in a loop and constant checking of scene's state, goes HERE.  
		//Code that executes while scene is already active.  
		
		
		//if(field2)
		//	transform.Rotate(new Vector3(field1,0,0));
		
		//HOW to move attached object around:  
		transform.Translate (Vector3.right * Input.GetAxis ("Horizontal"));//Found "Horizontal" by going to File, Project Settings, Input
		//Under project settings is a func/class you can call.  
		transform.Translate (Vector3.up * Input.GetAxis ("Vertical"));
		
	}
}


//Credits of this whole class go to:  http://www.youtube.com/watch?v=PO5_aqapZXY

using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour {

	public float zDistance = -7.0f;
	public float yDistance = 7.0f;

	public float smooth;

	public Transform follow;
	public Vector3 targetPosition;


	// Use this for initialization
	void Start () {
	
		//For the object attached to this script refer to other object,
		//that 'other object' must be the tag for this object using this script first.  
		//How:  Just go to object in inspector and change the 'tag' as that 'other object' 
		//in the tag tab.  
		follow = GameObject.FindWithTag("Player").transform;//how to get the transform/position of another object

	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void LateUpdate()
	{
		targetPosition = follow.position + follow.up * yDistance - follow.forward * zDistance;

		//Debug
		Debug.DrawRay (follow.position, Vector3.up * yDistance, Color.red);
		Debug.DrawRay (follow.position, -1f * follow.forward * zDistance, Color.blue);
		Debug.DrawLine (follow.position, targetPosition, Color.magenta);


		transform.position = Vector3.Lerp (transform.position, targetPosition, Time.deltaTime * smooth);


		transform.LookAt (follow);
	}





}

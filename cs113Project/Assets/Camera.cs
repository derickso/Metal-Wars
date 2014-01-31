using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	public Transform target;


	//public GameObject target = null;

	/*
	//For target.  Camera follows.  
	public float rotateSpeed = 25.0f;
	public float speed = 50.0f;
	*/

	//public float dampTime = 0.3f;
	//public float distance = 10.0f;

	//private Vector3 _velocity = Vector3.zero;

	// Use this for initialization
	void Start () {
	
		//transform.position = new Vector3(0,7,-7);
	}
	
	// Update is called once per frame
	void Update () {


		//float transAmount = speed * Time.deltaTime;
		//float rotateAmount = rotateSpeed * Time.deltaTime;



		//if(target!=null) 
		//{
			/*
			transform.position = target.transform.position + new Vector3(0,0,-7);
		//	if(target.transform.)
		//	{
		//		transform.Rotate(target.transform.position + new Vector3(0,7,-7));
		//	}

			//transform.LookAt (target.transform);


			//pitch
			if(Input.GetKey ("w"))
			{
				target.transform.Rotate (-rotateAmount, 0, 0);
				//transform.LookAt (target.transform.position+ (Vector3.up*2) + (Vector3.forward*5));
				//transform.Translate(new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z));
				//transform.Rotate (-rotateAmount, 0, 0);
				//transform.Translate (new Vector3(0,0,target.transform.local.y));
				//transform.RotateAround(target.transform.position, Vector3.right, -Time.deltaTime * 15);
				//transform.position = new Vector3(transform.position.x, transform.position.y, target.transform.localPosition.z);
				//transform.Rotate (target.transform.localRotation.x, target.transform.localRotation.y, target.transform.localRotation.z);
				transform.position = target.transform.position + new Vector3(0,transform.position.y,transform.position.z);
				transform.rotation = target.transform.rotation;

			}
			if(Input.GetKey ("s"))
			{
				target.transform.Rotate (rotateAmount, 0, 0);
				//transform.LookAt (target.transform.position+ (Vector3.up*2) + (Vector3.forward*5));
				//transform.Translate(new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z));
				//transform.Rotate (rotateAmount, 0, 0);
				//transform.RotateAround(target.transform.position, Vector3.right, Time.deltaTime * 15);
				//transform.position = new Vector3(transform.position.x, transform.position.y, target.transform.localPosition.z);
				//transform.Rotate (target.transform.localRotation.x, target.transform.localRotation.y, target.transform.localRotation.z);
				transform.position = target.transform.position + new Vector3(0,transform.position.y,transform.position.z);
				transform.rotation = target.transform.rotation;

			}
			
			//yaw
			if(Input.GetKey ("left"))
			{
				target.transform.Rotate (0, -rotateAmount, 0);
				//transform.Rotate (0, -rotateAmount, 0);
				//transform.LookAt (target.transform);
			}
			if(Input.GetKey ("right"))
			{
				target.transform.Rotate (0, rotateAmount, 0);
				//transform.Rotate (0, rotateAmount, 0);
				//transform.LookAt (target.transform);
			}
			
			
			//barrel roll left
			if(Input.GetKey ("x"))
			{
				target.transform.Rotate (0, 0, -rotateAmount);
				//transform.LookAt (target.transform);
				//transform.Rotate (0, 0, -rotateAmount);

			}
			
			//barrel roll right
			if(Input.GetKey ("z"))
			{
				target.transform.Rotate (0, 0, rotateAmount);
				//transform.LookAt (target.transform);
				//transform.Rotate (0, 0, rotateAmount);

			}
			
			//boost
			if(Input.GetKey ("a"))
			{
				target.transform.Translate (0, 0, -transAmount);
				//transform.Translate (0, 0, -transAmount);
				//transform.LookAt (target.transform);
			}
			
			//reverse
			if(Input.GetKey ("q"))
			{
				target.transform.Translate (0, 0, transAmount );
				//transform.Translate (0, 0, transAmount );
				//transform.LookAt (target.transform);
			}
			
			
			
		*/



			//Vector3 delta = target.transform.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, distance));

			//Vector3 destination = transform.position + delta;

			//transform.position = new Vector3.SmoothDamp(transform.position, destination, _velocity, dampTime);






		//}





		

	
	}

	void LateUpdate()
	{
		transform.position = target.position;
	}

}




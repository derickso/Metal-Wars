using UnityEngine;
using System.Collections;

public class Homing : MonoBehaviour {

	public float Speed;
	public float Turn;
	public GameObject closest = null;
	private Vector3 lastPos;	// used to calculate the velocity vector
	private bool readyToGo;

	void Start () {
		/*
		float closestDist = Mathf.Infinity;
		
		foreach (GameObject Target in targets) {
			float dist = (transform.position - Target.transform.position).sqrMagnitude;
			
			if (dist < closestDist) {
				closestDist = dist;
				closest = Target;
			}
		}*/
		if (PlayerView.missileTarget) {
			//Debug.Log ("ready to fire");
			closest = PlayerView.missileTarget;
			PlayerView.missileTarget = null;
			readyToGo = true;
		}
		else {
			PlayerView.missileTarget = null;
			readyToGo = false;
		}

		//Vector3 screenPos = GameObject.Find("ThirdPersonCamera").camera.WorldToScreenPoint(closest.transform.position);
		//Debug.Log("target is " + screenPos.x + " pixels from the left");

		lastPos = transform.position;
		//transform.Rotate (0, 90f * Time.deltaTime, 0);
	}

	void Update () {
		//Debug.Log (readyToGo);
		if (readyToGo) {
			PlayerView.missileTarget = null;
			// calculate the velocity vector:
			Vector3 vel = (transform.position - lastPos) / Time.deltaTime;
			lastPos = transform.position;
			// get the missile->target vector:
			Vector3 tgtDir = closest.transform.position - transform.position;
			float angle = Vector3.Angle (vel, tgtDir);
			if (angle > 60 && angle < 80) {
				// may be orbiting target - reduce the missile velocity
				Speed = 30 * Time.deltaTime;
			}

			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(closest.transform.position - transform.position), Turn * Time.deltaTime);
			transform.position += transform.forward * Speed * Time.deltaTime;
			//go.rigidbody.AddForce (go.transform.forward * 10000 * Time.deltaTime);
			Speed = Speed + 120 * Time.deltaTime;
			float dest = Vector3.Distance (closest.transform.position, transform.position);
			if (dest < 5) {
				Debug.Log ("hooey");
				Destroy (gameObject);
			}
		}
		else {
			transform.position += transform.forward * Speed * Time.deltaTime;
			Speed = Speed + 120 * Time.deltaTime;
		}
	}

	//void OnCollisionEnter(Collision collision) {
	//	Debug.Log ("COLIDER");
	//	Destroy (gameObject);
	//}
	
	/*
	void OnTriggerEnter (Collider otherObject) {
		//Debug.Log("EnemyBullets collided");
		//If it hits the player:
		if(otherObject.CompareTag("Enemy"))
		{
			Debug.Log ("BOX");
			Destroy (gameObject);
		}
	}*/
}
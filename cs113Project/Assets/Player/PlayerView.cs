using UnityEngine;
using System.Collections;

public class PlayerView : MonoBehaviour {

	public Camera FirstPersonCam;
	public Camera ThirdPersonCam;
	public GameObject FirstCross;
	public GameObject ThirdCross;
	public GameObject ThirdCrossRed;

	private bool viewActivated = false;

	public static GameObject missileTarget;


	// Use this for initialization
	void Start () {
		missileTarget = null;
		FirstPersonCam.enabled = false;
		ThirdPersonCam.enabled = true;
		FirstCross.renderer.enabled = false;
		ThirdCross.renderer.enabled = true;
		ThirdCrossRed.renderer.enabled = false;
		//ThirdIsEnabled = true;

		//transform.position = new Vector3(0,15.5f,-3);
		transform.Rotate (0,0,0);
		transform.localScale.Scale(new Vector3(1,1,1));
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] targets = GameObject.FindGameObjectsWithTag("Enemy");
		
		foreach (GameObject Target in targets) {
			Vector3 screenPos = GameObject.Find("ThirdPersonCamera").camera.WorldToScreenPoint(Target.transform.position);
			if (screenPos.x > 900 && screenPos.x < 1000 && screenPos.y > 400 && screenPos.y < 500)
			{
				//Debug.Log ("WE FOUND HIM BOYS");
				missileTarget = Target;
			}
			//else {ThirdCrossRed.renderer.enabled = false;
			//ThirdCross.renderer.enabled = true;
			//}
			//else {
			//	ThirdCrossRed.renderer.enabled = false;
			//	ThirdCross.renderer.enabled = true;
			//}
			//else {
			//	Debug.Log ("searching");
			//	missileTarget = null;
			//}
			//Debug.Log ("target at (" + screenPos.x + ", " + screenPos.y + ")");
		}
		if (missileTarget) {
			Vector3 tarScreenPos = GameObject.Find("ThirdPersonCamera").camera.WorldToScreenPoint(missileTarget.transform.position);
			if (tarScreenPos.x > 900 && tarScreenPos.x < 1000 && tarScreenPos.y > 400 && tarScreenPos.y < 500)
			{
				ThirdCrossRed.renderer.enabled = true;
				ThirdCross.renderer.enabled = false;
			}
			else {
				ThirdCrossRed.renderer.enabled = false;
				ThirdCross.renderer.enabled = true;
				missileTarget = null;
			}
		}
		else {
			ThirdCrossRed.renderer.enabled = false;
			ThirdCross.renderer.enabled = true;
		}
		
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

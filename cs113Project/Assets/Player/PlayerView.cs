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
	public Vector3 crosshairPos;


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

		crosshairPos = GameObject.Find("ThirdPersonCamera").camera.WorldToScreenPoint(ThirdCross.transform.position);
		Debug.Log ("crosssize is " + ThirdCross.renderer.bounds.size);
		Debug.Log ("chair at " + crosshairPos.x + ", " + crosshairPos.y);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] targets = GameObject.FindGameObjectsWithTag("Enemy");
		float lowerX = crosshairPos.x - 30;
		float upperX = crosshairPos.x + 40;
		float lowerY = crosshairPos.y - 58;
		float upperY = crosshairPos.y + 22;
		
		foreach (GameObject Target in targets) {
			Vector3 screenPos = GameObject.Find("ThirdPersonCamera").camera.WorldToScreenPoint(Target.transform.position);
			if (screenPos.x > lowerX && screenPos.x < upperX && screenPos.y > lowerY && screenPos.y < upperY)
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
			if (tarScreenPos.x > lowerX && tarScreenPos.x < upperX && tarScreenPos.y > lowerY && tarScreenPos.y < upperY)
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

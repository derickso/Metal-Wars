using UnityEngine;
using System.Collections;
//using UnityEditor;

public class PlayerView : MonoBehaviour {

	public Camera FirstPersonCam;
	public Camera ThirdPersonCam;
	public GameObject FirstCross;
	public GameObject ThirdCross;
	public GameObject ThirdCrossRed;
	public Rect crosshairRect;
	public GameObject playerIcon;

	private bool viewActivated = false;

	public static GameObject missileTarget;
	public Vector3 crosshairPos;

	public float lowerX;
	public float upperX;
	public float lowerY;
	public float upperY;


	//GameObject[] targets;



	public static int numOfEnemiesLeft = 0;

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
		//crosshairRect = GUIRectWithObject(ThirdCross);
		crosshairRect = BoundsToScreenRect (ThirdCross.renderer.bounds);
		
		//lowerX = crosshairPos.x - 30;
		//upperX = crosshairPos.x + 40;
		//lowerY = crosshairPos.y - 48;
		//upperY = crosshairPos.y + 22;

		//Debug.Log ("Lowerx: " + lowerX + ", UpperX: " + upperX + ", LowerY: " + lowerY + ", UpperY: " + upperY);
		//Debug.Log ("CrosshairRect " + crosshairRect.xMin + ", " + crosshairRect.yMin);
		//Debug.Log ("height: " + crosshairRect.height + ", width: " + crosshairRect.width);
		//Debug.Log ("crosssize is " + ThirdCross.renderer.bounds.size);
		//Debug.Log ("chair at " + crosshairPos.x + ", " + crosshairPos.y);

		//numOfEnemiesLeft = 0;

	}
	
	// Update is called once per frame
	void Update () {
		if (Player.isDead)
		    playerIcon.renderer.enabled = false;
		   
		GameObject[] targets = GameObject.FindGameObjectsWithTag("Enemy");
		//targets = GameObject.FindGameObjectsWithTag("Enemy");//Reference/Re-Reference


		//numOfEnemiesLeft = targets.Length;
		//Debug.Log (numOfEnemiesLeft);

		/*
		//If all enemies destroyed, reset targets list back to 0
		if(numOfEnemiesLeft <= 0)
		{
			for(int i = 0; i < targets.Length; i++)
			{
				Destroy (GameObject.FindGameObjectsWithTag("Enemy")[i]);
			}

			targets = new GameObject[30];//Pick any size number.  It's going to be re-referenced anyways.  
		}
		*/



		
		foreach (GameObject Target in targets) {
			Vector3 screenPos = GameObject.Find("ThirdPersonCamera").camera.WorldToScreenPoint(Target.transform.position);

			if (screenPos.x > (crosshairRect.xMin - crosshairRect.width) && screenPos.x < (crosshairRect.xMax + (crosshairRect.width * 2)) && screenPos.y > (crosshairRect.yMin) && screenPos.y < (crosshairRect.yMax + (crosshairRect.height * 2)))
			//if (screenPos.x > lowerX && screenPos.x < upperX && screenPos.y > lowerY && screenPos.y < upperY)
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
			if (tarScreenPos.x > (crosshairRect.xMin - crosshairRect.width) && tarScreenPos.x < (crosshairRect.xMax + (crosshairRect.width * 2)) && tarScreenPos.y > (crosshairRect.yMin) && tarScreenPos.y < (crosshairRect.yMax + (crosshairRect.height * 2)))			//if (tarScreenPos.x > crosshairRect.xMin && tarScreenPos.x < crosshairRect.xMax && tarScreenPos.y > crosshairRect.yMin && tarScreenPos.y < crosshairRect.yMax)
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

		if(Input.GetKey (KeyCode.A))
		{
			playerIcon.transform.Rotate (0, 1.26f, 0);
		}
		if(Input.GetKey (KeyCode.D))
		{
			playerIcon.transform.Rotate (0, -1.26f, 0);
		}
	}

	/*
	Rect GUIRectWithObject(GameObject go)
	{
		Vector3 cen = go.renderer.bounds.center;
		Vector3 ext = go.renderer.bounds.extents;
		Vector2[] extentPoints = new Vector2[8]
		{
			HandleUtility.WorldToGUIPoint(new Vector3(cen.x-ext.x, cen.y-ext.y, cen.z-ext.z)),
			HandleUtility.WorldToGUIPoint(new Vector3(cen.x+ext.x, cen.y-ext.y, cen.z-ext.z)),
			HandleUtility.WorldToGUIPoint(new Vector3(cen.x-ext.x, cen.y-ext.y, cen.z+ext.z)),
			HandleUtility.WorldToGUIPoint(new Vector3(cen.x+ext.x, cen.y-ext.y, cen.z+ext.z)),
			
			HandleUtility.WorldToGUIPoint(new Vector3(cen.x-ext.x, cen.y+ext.y, cen.z-ext.z)),
			HandleUtility.WorldToGUIPoint(new Vector3(cen.x+ext.x, cen.y+ext.y, cen.z-ext.z)),
			HandleUtility.WorldToGUIPoint(new Vector3(cen.x-ext.x, cen.y+ext.y, cen.z+ext.z)),
			HandleUtility.WorldToGUIPoint(new Vector3(cen.x+ext.x, cen.y+ext.y, cen.z+ext.z))
		};
		
		Vector2 min = extentPoints[0];
		Vector2 max = extentPoints[0];
		
		foreach(Vector2 v in extentPoints)
		{
			min = Vector2.Min(min, v);
			max = Vector2.Max(max, v);
		}
		
		return new Rect(min.x, min.y, max.x-min.x, max.y-min.y);
	}
	*/

	Rect BoundsToScreenRect(Bounds bounds)
	{
		// Get mesh origin and farthest extent (this works best with simple convex meshes)
		Vector3 origin = GameObject.Find("ThirdPersonCamera").camera.WorldToScreenPoint(new Vector3(bounds.min.x, bounds.max.y, 0f));
		Vector3 extent = GameObject.Find("ThirdPersonCamera").camera.WorldToScreenPoint(new Vector3(bounds.max.x, bounds.min.y, 0f));
		
		// Create rect in screen space and return - does not account for camera perspective
		return new Rect(origin.x, Screen.height - origin.y, extent.x - origin.x, origin.y - extent.y);
	}
}

using UnityEngine;
using System.Collections;

//Missile shoots here
//Missile heat-seeks here

public class MissileShoot : MonoBehaviour {


	public GameObject goProjectilePrefab;
	private GameObject[] argoProjectiles = new GameObject[900];
	private int iNext = 0;
	private float fMag = 50000.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up




	public GameObject target;


	// Use this for initialization
	void Start () {
	
		for (int i = 0; i < argoProjectiles.Length; i++) 
		{
			argoProjectiles[i] = (GameObject)Instantiate (goProjectilePrefab);
			argoProjectiles[i].SetActive (false);
		}

	}
	
	// Update is called once per frame
	void Update () {
	


		if (Input.GetKeyDown(KeyCode.Q)) //Just hold down to shoot
		{
			

			
			
			
			
			
			GameObject go = argoProjectiles[iNext++];
			
			if (iNext >= argoProjectiles.Length) iNext = 0;
			
			go.SetActive (true);
			go.rigidbody.velocity = Vector3.zero;
			go.transform.position = transform.position;
			go.transform.rotation = transform.rotation;
			go.rigidbody.AddForce (transform.forward * fMag);
			
			//temp = go;


			//Heat Seeking Code:  
			Vector3 newTarget = target.transform.position - transform.position;
			
			go.rigidbody.velocity =  newTarget.normalized * 800;
			
			go.transform.LookAt (target.transform.position);

			
			//if()
			//{
			//}

		}








	}
}

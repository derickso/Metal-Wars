using UnityEngine;
using System.Collections;

//Missile shoots here
//Missile heat-seeks here

public class MissileShoot : MonoBehaviour {


	public GameObject goProjectilePrefab;
	private GameObject[] argoProjectiles = new GameObject[900];
	private int iNext = 0;
	private float fMag = 10000.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	


	public GameObject target;


	// Use this for initialization
	void Start () {
		goProjectilePrefab.SetActive (false);
		for (int i = 0; i < argoProjectiles.Length; i++) 
		{
			argoProjectiles[i] = (GameObject)Instantiate (goProjectilePrefab);
			//argoProjectiles[i].transform.Rotate(0,0,90f);
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
			//go.transform.rotation = transform.rotation;
			//go.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
			//go.transform.LookAt (Vector3.zero);
			//go.transform.rotation = transform.LookAt(transform.position + rigidbody.velocity);
			//go.transform.Rotate (0,0,0);
			go.rigidbody.AddForce (transform.forward * fMag);
			
			//temp = go;


			//Heat Seeking Code:  
			//Vector3 newTarget = target.transform.position - transform.position;
			
			//go.rigidbody.velocity =  newTarget.normalized * 800;
			
			//go.transform.LookAt (target.transform.position);

			
			//if()
			//{
			//}

		}








	}
}

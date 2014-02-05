using UnityEngine;
using System.Collections;

public class LaserShoot : MonoBehaviour {

	//public Rigidbody projectile;
	//public float speed = 99999999999999999999999.0f;

	//public Transform projectile2;

	//_________VERSION 2_____________
	public GameObject goProjectilePrefab;
	private GameObject[] argoProjectiles = new GameObject[900];
	private int iNext = 0;
	private float fMag = 50000.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up


	private GameObject temp;//This allows storing the temporary bullet and destroys it if needed
	
	// Use this for initialization
	void Start () 
	{
	
		for (int i = 0; i < argoProjectiles.Length; i++) {
			argoProjectiles[i] = (GameObject)Instantiate (goProjectilePrefab);
			argoProjectiles[i].SetActive (false);
		}
	
	
	}

// Update is called once per frame
	void Update () {
	

		//if(Input.GetKeyDown ("f"))
		//{
			//
			//Rigidbody instatiatedProjectile = Instantiate (projectile, 
			//                                               transform.position, 
			//                                               transform.rotation) as Rigidbody;


			//instatiatedProjectile.velocity = transform.TransformDirection (new Vector3(0,0,speed));
			//



		//}


		//______________VERSION 2_________________________

		//if (Input.GetKeyDown(KeyCode.Space)) //To press down every time
		if(Input.GetKey (KeyCode.Space))//will fire as long as it's pressed
		{
			GameObject go = argoProjectiles[iNext++];

			if (iNext >= argoProjectiles.Length) iNext = 0;


			go.SetActive (true);
			go.rigidbody.velocity = Vector3.zero;
			go.transform.position = transform.position;
			go.transform.rotation = transform.rotation;
			go.rigidbody.AddForce (transform.forward * fMag);

			temp = go;//Point to this so that you can destroy bullet every time it hits.
			//Wait, thing destroys anyways after you leave this?  
		}

		//Destroy (temp);
		
	}
}

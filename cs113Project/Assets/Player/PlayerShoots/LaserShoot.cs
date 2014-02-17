using UnityEngine;
using System.Collections;

public class LaserShoot : MonoBehaviour {

	//public Rigidbody projectile;
	//public float speed = 99999999999999999999999.0f;

	public ParticleSystem initialLaserFlash;
	public ParticleSystem laserMuzzle;


	//public Transform projectile2;

	//_________VERSION 2_____________
	public GameObject goProjectilePrefab;
	private GameObject[] argoProjectiles = new GameObject[900];
	private int iNext = 0;
	private float fMag = 50000.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	

	//private GameObject temp;


	// Use this for initialization
	void Start () 
	{

		initialLaserFlash.enableEmission = false;
		laserMuzzle.enableEmission = false;
	
		for (int i = 0; i < argoProjectiles.Length; i++) 
		{
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

		initialLaserFlash.enableEmission = false;
		laserMuzzle.enableEmission = false;

		//if (Input.GetKeyDown(KeyCode.Space)) //Must press it every time to shoot
		if (Input.GetKey(KeyCode.Space)) //Just hold down to shoot
		{

			FireLaser();

			//temp = go;
		}

		//Destroy(temp);
		
	}
	
	void FireLaser () {
		//Enable the flashes
		initialLaserFlash.enableEmission = true;
		laserMuzzle.enableEmission = true;

		//Take the correct projectile
		GameObject go = argoProjectiles[iNext++];
		
		if (iNext >= argoProjectiles.Length) iNext = 0;

		//Fire the projectile
		go.SetActive (true);
		go.rigidbody.velocity = Vector3.zero;
		go.transform.position = transform.position;
		go.transform.rotation = transform.rotation;
		//go.rigidbody.velocity = transform.forward * fMag;
		go.rigidbody.AddForce(transform.forward * fMag);
	}
}

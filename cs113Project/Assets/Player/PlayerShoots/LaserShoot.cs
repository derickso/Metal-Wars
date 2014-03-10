using UnityEngine;
using System.Collections;

public class LaserShoot : MonoBehaviour {

	//public Rigidbody projectile;
	//public float speed = 99999999999999999999999.0f;

	public ParticleSystem initialLaserFlash;
	public ParticleSystem laserMuzzle;

	public AudioClip sPlayerLaser;

	//public Transform projectile2;

	//_________VERSION 2_____________
	public GameObject goProjectilePrefab;
	private GameObject[] argoProjectiles = new GameObject[50];
	private int iNext = 0;
	private float fMag = 600.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	private float fireNextTime = 0.0f;
	private float fireNextDelay = 0.08f;

	//private GameObject temp;


	// Use this for initialization
	void Start () 
	{

		initialLaserFlash.enableEmission = false;
		laserMuzzle.enableEmission = false;
	
		//for (int i = 0; i < argoProjectiles.Length; i++) 
		//{
		//	argoProjectiles[i] = (GameObject)Instantiate (goProjectilePrefab);
		//	argoProjectiles[i].SetActive (false);
		//}
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
			//Enable the flashes
			initialLaserFlash.enableEmission = true;
			laserMuzzle.enableEmission = true;

			//if the delay time passed it fires
			if(fireNextTime < Time.time)
			{
				//Fire a laser
				FireLaser();

				audio.PlayOneShot (sPlayerLaser);

				//Adds the fireDelay to the time verifier
				fireNextTime = Time.time + fireNextDelay;
			}
			//temp = go;
		}

		//Destroy(temp);
		
	}
	
	void FireLaser () {

		//Take the correct projectile
		//GameObject go = argoProjectiles[iNext++];
		GameObject go = (GameObject)Instantiate (goProjectilePrefab);
		
		//if (iNext >= argoProjectiles.Length) iNext = 0;

		//Fire the projectile
		//go.SetActive (true);
		//go.rigidbody.velocity = Vector3.zero;
		go.transform.position = transform.position + transform.forward*10;
		go.transform.rotation = transform.rotation;
		go.transform.Rotate(90,0,0);//Needed to make the bullet go in the right position
		go.rigidbody.velocity = transform.forward * fMag;
		//go.rigidbody.AddForce(transform.forward * fMag * 100);
	}
}

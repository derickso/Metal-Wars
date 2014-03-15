using UnityEngine;
using System.Collections;

public class EnemiesShoots : MonoBehaviour {

	//GameObjects
	public GameObject goProjectilePrefab;
	private GameObject[] argoProjectiles = new GameObject[80];
	private GameObject player;

	public ParticleSystem initialGunFlash;
	public ParticleSystem gunFlash;

	//Fire
	private int iNext = 0;
	private float fMag = 300.0f;

	public float fireRate = 300;
	public float damage = 1.0f;

	private float fireNextTime = 0.0f;
	private float fireNextDelay = 0.0f;

	// Use this for initialization
	void Start () {
		initialGunFlash.enableEmission = false;
		gunFlash.enableEmission = false;

		player = GameObject.FindGameObjectWithTag("Player");
		
		for (int i = 0; i < argoProjectiles.Length; i++) 
		{
			argoProjectiles[i] = (GameObject)Instantiate (goProjectilePrefab);
			EnemiesBullets bullets = (EnemiesBullets)argoProjectiles[i].GetComponent("EnemiesBullets");
			bullets.damage = damage;
			argoProjectiles[i].SetActive (false);
		}

		//Calculate the fire delay based in the fireRate
		fireNextDelay = 26/fireRate;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = player.transform.position - transform.position;
		float angle = Vector3.Angle(direction, transform.forward);
		//Debug.Log("Angle "+angle);

		initialGunFlash.enableEmission = false;
		gunFlash.enableEmission = false;

		if(angle < 30.0f)
		{
			if(fireNextTime < Time.time)
			{
				FireBullet();

				//Adds the fireDelay to the time verifier
				fireNextTime = Time.time + fireNextDelay;

				//transform.Rotate(0, 180, 0);
				//go.rigidbody.AddForce (transform.forward * fMag);
				//transform.Rotate(0, 180, 0);
			}
		}
	}

	void FireBullet() {
		//Fire flashes
		initialGunFlash.enableEmission = true;
		gunFlash.enableEmission = true;

		//Take a bullet
		GameObject go = argoProjectiles[iNext++];
		
		if(iNext >= argoProjectiles.Length)
			iNext = 0;

		//Fire the bullet
		audio.Play ();
		go.SetActive (true);
		go.transform.position = transform.position;
		go.transform.rotation = transform.rotation;
		go.transform.Rotate(90,0,0);//Needed to make the bullet go in the right position
		go.rigidbody.velocity = transform.forward * fMag;
	}
	
}

using UnityEngine;
using System.Collections;

public class EnemiesShoots : MonoBehaviour {

	//GameObjects
	public GameObject goProjectilePrefab;
	private GameObject[] argoProjectiles = new GameObject[50];
	private GameObject player;

	public ParticleSystem initialGunFlash;
	public ParticleSystem gunFlash;

	//Fire
	private int iNext = 0;
	private float fMag = 300.0f;

	// Use this for initialization
	void Start () {
		initialGunFlash.enableEmission = false;
		gunFlash.enableEmission = false;

		player = GameObject.FindGameObjectWithTag("Player");
		
		for (int i = 0; i < argoProjectiles.Length; i++) 
		{
			argoProjectiles[i] = (GameObject)Instantiate (goProjectilePrefab);
			argoProjectiles[i].SetActive (false);
		}
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

			FireBullets();

			//transform.Rotate(0, 180, 0);
			//go.rigidbody.AddForce (transform.forward * fMag);
			//transform.Rotate(0, 180, 0);
		}
	}

	void FireBullets() {
		//Fire flashes
		initialGunFlash.enableEmission = true;
		gunFlash.enableEmission = true;

		//Take a bullet
		GameObject go = argoProjectiles[iNext++];
		
		if(iNext == argoProjectiles.Length)
			iNext = 0;

		//Fire the bullet
		go.SetActive (true);
		go.rigidbody.velocity = transform.forward * fMag;
		go.transform.position = transform.position;
		go.transform.rotation = transform.rotation;
	}
	
}

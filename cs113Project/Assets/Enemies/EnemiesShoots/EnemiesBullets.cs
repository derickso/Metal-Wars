using UnityEngine;
using System.Collections;

public class EnemiesBullets : MonoBehaviour {

	//public int speed;
	public float damage;

	// Use this for initialization
	void Start () {
		//speed = 100;
		damage = 3.0f;
	}
	
	// Update is called once per frame
	void Update () {
		//rigidbody.velocity = transform.forward * speed;
	}
	
	void OnTriggerEnter (Collider otherObject) {
		//Debug.Log("EnemyBullets collided");
		//If it hits the player:
		if(otherObject.CompareTag("Player"))
		{
			//The player receives damage
			Player player = (Player)otherObject.gameObject.GetComponent("Player");
			player.receiveDamage(damage);

			//Vanishes the gameObject
			gameObject.SetActive(false);
			//Destroy (this);
		}
	}

	//void OnCollisionEnter (Collision collision) {
		//Dissapear if it hits anything
	//	gameObject.SetActive(false);
	//}

	//On trigger collision exit
	void OnTriggerExit (Collider otherObject) {
		//If the bullet get out fo the map bounds it stops
		if(otherObject.CompareTag("MapBounds"))
			//gameObject.SetActive(false);
			Destroy (this);
	}
}

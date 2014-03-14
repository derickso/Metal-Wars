using UnityEngine;
using System.Collections;

public class LaserBullets : MonoBehaviour {

	//hit effect that will be showed once it hits an enemy
	public GameObject hitEffect;

	//public int speed;
	public float damage;

	public float spawnTime;

	// Use this for initialization
	void Start () {
		//speed = 1000;
		damage = 49f * Menu.damageModifier;
		//rigidbody.velocity = transform.forward * speed;
		//Debug.Log ("Time is: " + Time.time);
		spawnTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= spawnTime + 3)
			UnityEngine.GameObject.Destroy (gameObject);
	}

	/*void OnTriggerEnter (Collider otherObject) {
		//Debug.Log("PlayerBullets collided");
		//if it hits an enemy:
		if(otherObject.CompareTag("Enemy"))
		{
			Debug.Log("Name: "+otherObject.name);
			//Make damage to the enemy
			Enemy enemy = (Enemy)otherObject.gameObject.GetComponent("Enemy");
			enemy.receiveDamage(damage);

			//Make the hit effects
			hit();
		}
	}*/

	void OnCollisionEnter (Collision collision) {
		//Debug.Log ("hit " + collision.gameObject.name);
		
		//Make the hit effects
		if (collision.collider.CompareTag ("Enemy"))
		{
			//Debug.Log ("hit " + collision.collider.name + " for " + damage + " damage");
			Enemy enemy = (Enemy)collision.collider.transform.parent.gameObject.GetComponent("Enemy");
			//if (enemy != null)
				enemy.receiveDamage(damage);
			hit();
		}
		
		Destroy (gameObject);
	}

	//On trigger collision exit
	void OnTriggerExit (Collider otherObject) {
		//If the bullet get out fo the map bounds it stops
		if(otherObject.CompareTag("MapBounds"))
			gameObject.SetActive(false);
	}

	//Function that executes the hit effect procedure,
	//creating the hitEffect and setting the gameObject to false.
	void hit(){
		GameObject hit = (GameObject)Instantiate(hitEffect, transform.position, Quaternion.identity);
		Destroy(hit,0.4f);
		gameObject.SetActive(false);
	}
}

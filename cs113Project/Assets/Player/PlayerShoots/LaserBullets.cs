using UnityEngine;
using System.Collections;

public class LaserBullets : MonoBehaviour {

	//hit effect that will be showed once it hits an enemy
	public GameObject hitEffect;

	//public int speed;
	public int damage;

	// Use this for initialization
	void Start () {
		//speed = 1000;
		damage = 5;
		//rigidbody.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider otherObject) {
		//Debug.Log("PlayerBullets collided");
		if(otherObject.CompareTag("Enemy"))
		{
			Enemy enemy = (Enemy)otherObject.gameObject.GetComponent("Enemy");
			enemy.receiveDamage(damage);

			hit();
		}
	}

	void OnCollisionEnter (Collision collision) {
		hit();
	}

	void hit(){
		GameObject hit = (GameObject)Instantiate(hitEffect, transform.position, Quaternion.identity);
		Destroy(hit,0.4f);
		gameObject.SetActive(false);
	}
}

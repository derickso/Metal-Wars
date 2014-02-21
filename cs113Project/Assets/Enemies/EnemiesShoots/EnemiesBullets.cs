using UnityEngine;
using System.Collections;

public class EnemiesBullets : MonoBehaviour {

	//public int speed;
	public float damage;
	
	// Use this for initialization
	void Start () {
		//speed = 100;
		damage = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		//rigidbody.velocity = transform.forward * speed;
	}
	
	void OnTriggerEnter (Collider otherObject) {
		//Debug.Log("EnemyBullets collided");
		if(otherObject.CompareTag("Player"))
		{
			Player player = (Player)otherObject.gameObject.GetComponent("Player");
			player.receiveDamage(damage);

			gameObject.SetActive(false);
		}
	}
}

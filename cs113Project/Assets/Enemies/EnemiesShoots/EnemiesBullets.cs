using UnityEngine;
using System.Collections;

public class EnemiesBullets : MonoBehaviour {

	public int speed;
	public int damage;
	
	// Use this for initialization
	void Start () {
		speed = 1000;
		damage = 1;
		//rigidbody.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter (Collider otherObject) {
		Debug.Log("Collided with player");
		if(otherObject.tag == "Player")
		{
			Player player = (Player)otherObject.gameObject.GetComponent("Player");
			player.receiveDamage(damage);
		}
	}
}

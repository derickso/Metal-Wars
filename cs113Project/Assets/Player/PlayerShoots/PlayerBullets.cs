using UnityEngine;
using System.Collections;

public class PlayerBullets : MonoBehaviour {

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
		Debug.Log("Collided with enemy");
		if(otherObject.tag == "Enemy")
		{
			Enemy enemy = (Enemy)otherObject.gameObject.GetComponent("Enemy");
			enemy.receiveDamage(damage);
		}
	}
}

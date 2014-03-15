using UnityEngine;
using System.Collections;

public class Scout : Enemy {
	
	//Sounds
	//public AudioClip sLoopingSound;
	
	//Speeds
	//public float rotateSpeed;
	//private const float speed = 60.0f;

	//Enemy armor
	//private int armor;

	// Use this for initialization
	void Start () {
		base.startInit();

		armor = 60;

		score = 100;

		speed = 60.0f;
		rotateSpeed = Random.Range(50,70);
		//audio.loop = true;
		//audio.clip = sLoopingSound;
		//audio.Play ();

		setPath(PATH_EIGHT);
	}

	public override void receiveDamage(float damage) {
		//public bool receiveDamage(int damage) {
		//audio.clip = sLoopingSound;
		//audio.bypassEffects = true;
		//audio.Play();
		armor = armor - damage;
		//Debug.Log("Enemy Damaged for " + damage + ". Armor now = " + armor);
		if(armor < 1)
		{

			//Debug.Log ("enemy should die here");
			//Create explosion HERE
			GameObject expl = (GameObject)Instantiate(explosion, transform.position, Quaternion.identity);

			//Debug.Log ("reached audio");
			//Create explosion sound effect HERE
			GameObject explsound = (GameObject)Instantiate (explosionSound, transform.position, Quaternion.identity);
			
			//Pass to the player the score relative to this enemy
			((Player)GameObject.FindWithTag("Player").GetComponent("Player")).addScore(score);
			
			//Changes the number of current enemies left
			//PlayerView.numOfEnemiesLeft--;
			//Debug.Log (PlayerView.numOfEnemiesLeft);
			SpawnManager.decrementEnemiesAliveNumber();
			//Debug.Log (SpawnManager.getEnemiesAliveNumber() + " enemies left.");
			//Destroy the explosion and the game object
			Destroy(expl,2);
			//Destroy (explsound);
			Destroy(gameObject);
		}
	}
}

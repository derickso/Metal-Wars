using UnityEngine;
using System.Collections;

public class Terrain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/*
	void OnTriggerEnter (Collider otherObject) 
	{
		//Debug.Log("EnemyBullets collided");
		if(otherObject.tag == "Player")
		{
			Player player = (Player)otherObject.gameObject.GetComponent("Player");
			player.receiveDamage(100);
			
			gameObject.SetActive(false);
		}
	}
	*/
}

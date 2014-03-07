using UnityEngine;
using System.Collections;

public class TerrainManager : MonoBehaviour {
	
	private int terrainDamage;
	
	// Use this for initialization
	void Start () {
		terrainDamage = 500;//Passing a high number to be sure that the player will die
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter (Collider otherObject)
	{
		//Debug.Log("EnemyBullets collided");
		if(otherObject.CompareTag("Player"))
		{
			Player player = (Player)otherObject.gameObject.GetComponent("Player");
			player.receiveDamage(terrainDamage);
			
		}else if(otherObject.CompareTag("Enemy"))
		{
			Enemy enemy = (Enemy)otherObject.gameObject.GetComponent("Enemy");
			enemy.receiveDamage(terrainDamage);
		}
	}
}
using UnityEngine;
using System.Collections;

public abstract class Enemy : MonoBehaviour {

	public GameObject explosion;
	protected int armor;
	
	public void receiveDamage(int damage){
		armor -= damage;
		Debug.Log("Levou dano!!"+damage);
		if(armor < 1)
		{
			GameObject expl = (GameObject)Instantiate(explosion, transform.position, Quaternion.identity);
			//Create explosion HERE
			Destroy(gameObject);
			Destroy(expl,3);
		}
	}

}

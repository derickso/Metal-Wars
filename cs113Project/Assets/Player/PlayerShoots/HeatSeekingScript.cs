using UnityEngine;
using System.Collections;

public class HeatSeekingScript : MonoBehaviour {

	public string searchTag;
	private GameObject closest;//Enemy(Object2) closest to missile(Object1)
	private Transform target;


	// Use this for initialization
	void Start () {
	
		//searchTag = "Enemy";
		closest = FindNearestEnemy();
		if(closest)
		{
			target = closest.transform;
		}
	}
	
	// Update is called once per frame
	void Update () {

		//transform.LookAt (target);
		//transform.Translate(Vector3.forward * 100.0f * Time.deltaTime);
	
	}

	//Taking out the argument.  Comments below assume that argument is used.  Version with argument STILL useful.  
	GameObject FindNearestEnemy()//(GameObject missile)//argument can actually be any game object1 you plan on using this function for
	{
		GameObject[] enemies;
		enemies = GameObject.FindGameObjectsWithTag (searchTag);
		
		GameObject nearestEnemy = null;
		float distance = Mathf.Infinity;//starting limit for update code below
		
		//Vector3 missilePosition = missile.transform.position;//argument can actually be any position game object1 you plan on using this for
		Vector3 missilePosition = transform.position;
		
		//Keep searching for enemy and 
		//update the nearest enemy everytime you find one that is closer to player than the one found before.  
		//VERY SIMPLE!!!!  You KNOW THIS ALREADY!!!!
		
		foreach(GameObject enem in enemies)//argument can actually be any targeted game object2 in a list of any gameObjects2 you plan on using this for
		{
			Vector3 dist = enem.transform.position - missilePosition;
			float distRefined = dist.sqrMagnitude;//<--HOW to convert vector to float //Special needed for 3D. do calculation.sqrMagnitude everytime calculations of matrix(vector) stuff is done.  
			
			if(distRefined < distance)//if distance btwn player(object1) and enemy(object2) is less than the minimum engagement distance,
			{
				nearestEnemy = enem;
				distance = distRefined;
			}
		}
		
		return nearestEnemy;//return object closest to object in the argument of this func
		
		
	}


}

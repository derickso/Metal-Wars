using UnityEngine;
using System.Collections;

//Missile shoots here
//Missile heat-seeks here

public class MissileShoot : MonoBehaviour {
	
	
	public GameObject goProjectilePrefab;
	private GameObject[] argoProjectiles = new GameObject[900];
	//private int iNext = 0;
	private float fMag = 10000.0f;//1 Frame = 1000. So bulletspeed = playerSpeed * 1000 to keep up
	
	//private GameObject go;//Reference to this changes everytime a new object is made
	
	/*
	//Heat-Seeking stuff

	public GameObject playerRef;
	//private int distanceBtwnPlayerAndEnemy = 5000;


	private string searchTag = "Enemy";
	private GameObject closest;  //Enemy that's closest to missile
	private Transform target;



	private GameObject targetRef;//Replaces fields target1, target2, target3, target4.  



	//public GameObject target1;
	private int totalNumOfSCOUTEnemies = 3;//Change this number when you add in more enemies
	private GameObject[] enemies1 = new GameObject[100];
	
	
	//public GameObject target2;
	private int totalNumOfZEROSENEnemies = 3;//Change this number when you add in more enemies
	private GameObject[] enemies2 = new GameObject[100];
	
	//public GameObject target3;
	private int totalNumOfCLASS3Enemies = 3;//Change this number when you add in more enemies
	private GameObject[] enemies3 = new GameObject[100];
	
	//public GameObject target4;
	private int totalNumOfCLASS4Enemies = 3;//Change this number when you add in more enemies
	private GameObject[] enemies4 = new GameObject[100];
	*/
	
	// Use this for initialization
	void Start () {
		//goProjectilePrefab.SetActive (false);
		for (int i = 0; i < argoProjectiles.Length; i++)
		{
			//argoProjectiles[i] = (GameObject)Instantiate (goProjectilePrefab,this.gameObject.transform.position,this.gameObject.transform.rotation);//
			//argoProjectiles[i].transform.Rotate(0,180f,0);
			//argoProjectiles[i].SetActive (false);//
		}
		
		
		
		
		/*
		//Make all the enemy planes in the game possible for selection
		
		for(int i = 1; i <= totalNumOfSCOUTEnemies; i++)//Don't use enemy size array list otherwise you cause null reference objects.
		{
			//Use i as the prefix of the name
			enemies1[i-1] = GameObject.Find("Scout"+i);
			
			
		}
		*/
		
		
		
		
	}
	
	// Update is called once per frame
	void Update () {

		//During update, search through ALL the enemies on the map automatically <----Goes outside of button pressed b/c we want to check 
		//EVERY TIME the button is pressed, not just one i when q is pressed.  <---IDEA so far

		//for(int i = 0; i < totalNumOfSCOUTEnemies; i++)
		//{

			//if(enemies1[i].renderer.isVisible)
			
			//playerRef = GameObject.FindGameObjectWithTag ("Enemy");
			//playerRef = GameObject.Find("Scout"+i);

			
			//{
				//_If you press the fire button down during any time in this update loop:_

				//float rotateAmount = 25f * Time.deltaTime;
				//if (Input.GetKeyDown(KeyCode.Q) && Player.numMissiles != 0) //Just hold down to shoot
		if (Input.GetKeyDown(KeyCode.Q) && (Time.timeScale != 0))
				{	

					//Heat Seeking Code:

					//IDEA:  Missile fires ONLY IF the current enemy is Visible on screen!!!!


						//GameObject go = argoProjectiles[iNext++];
						GameObject go = (GameObject)Instantiate (goProjectilePrefab,transform.position,transform.rotation);
						//go = (GameObject)Instantiate (goProjectilePrefab,this.gameObject.transform.position,this.gameObject.transform.rotation);	
						//if (iNext >= argoProjectiles.Length) iNext = 0;
							
						go.SetActive (true);
						go.rigidbody.velocity = Vector3.zero;
						go.transform.position = transform.position;//
						//go.transform.rotation = Quaternion.Euler(rotateAmount,0,0);
						//go.transform.Rotate (90, 90, 90);
						//go.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);//
						//go.transform.LookAt (Vector3.zero);//
						//go.transform.rotation = transform.LookAt(transform.position + rigidbody.velocity);//
						go.transform.Rotate (0,270,0);//DO NOT COMMENT OUT!!!!
						go.rigidbody.AddForce (transform.forward * fMag/10);
						//Player.numMissiles = Player.numMissiles - 0.5;//Unlimited ammo for now
						//temp = go;
							
							
							
						//Player.healthAmount = Player.healthAmount - .125f;
							

						//go.transform.LookAt (enemies1[i].transform.position, Vector3.forward);
						//transform.Translate (Vector3.forward * Time.deltaTime * 1);



						/*
						closest = FindNearestEnemy (go);
						if(closest)
						{
							target = closest.transform;
						}
						
						transform.LookAt (target);
						transform.Translate (Vector3.forward * 5.0f * Time.deltaTime);
						*/
				}

					
			//}
			
		//}


		
		
	}

	/*
	//AKA find nearest object
	GameObject FindNearestEnemy(GameObject missile)//argument can actually be any game object1 you plan on using this function for
	{
		GameObject[] enemies;
		enemies = GameObject.FindGameObjectsWithTag (searchTag);

		GameObject nearestEnemy = null;
		float distance = Mathf.Infinity;//starting limit for update code below

		Vector3 missilePosition = missile.transform.position;//argument can actually be any position game object1 you plan on using this for


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
	*/



}
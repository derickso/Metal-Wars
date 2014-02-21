using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {


	//This object spawns another enemy every time one is destroyed

	//Actually,
	//This object spawns the next premade wave of enemies everytime the previous wave
	//is destroyed.  
	//This should work like the lasershoot script.  

	//We also need to make an array of different waypoints possible.  
	//Every time any of the enemies is spawned, it is given one of the waypoints.  
		


	//public Transform projectile2;
	
	//_________VERSION 2_____________

	//Outline:  
	public GameObject goProjectilePrefab;
	private GameObject[] argoProjectiles = new GameObject[300];
	private int iNext = 0;
	private float fMag = 600.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	private float fireNextTime = 0.0f;
	private float fireNextDelay = 0.08f;


	//Enemy 1
	public GameObject goScoutPrefab;//Scout
	private GameObject[] argoScouts = new GameObject[300];
	private int iNextScout = 0;
	private float fMagScout = 600.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	private float spawnNextTime1 = 0.0f;
	private float spawnNextDelay1 = 0.08f;

	//Enemy 2
	public GameObject goLightEnemPrefab;//LightPlane Enemy
	private GameObject[] argoLightEnems = new GameObject[300];
	private int iNextLightEnems = 0;
	private float fMagLightEnem = 600.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	private float spawnNextTime2 = 0.0f;
	private float spawnNextDelay2 = 0.08f;

	//Enemy 3
	public GameObject goMediumEnemPrefab;//MediumPlane Enemy
	private GameObject[] argoMediumEnems = new GameObject[300];
	private int iNextMediumEnems = 0;
	private float fMagMediumEnem = 600.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	private float spawnNextTime3 = 0.0f;
	private float spawnNextDelay3 = 0.08f;

	//Enemy 4
	public GameObject goHeavyEnemPrefab;//HeavyPlane Enemy
	private GameObject[] argoHeavyEnems = new GameObject[300];
	private int iNextHeavyEnems = 0;
	private float fMagHeavyEnem = 600.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	private float spawnNextTime4 = 0.0f;
	private float spawnNextDelay4 = 0.08f;

	
	//private GameObject temp;

	private int levelAndWaveMarker;//Starts at 1

	//Level 1 has 3 waves
	private int lvl1wave1Mark = 1;
	private int lvl1wave2Mark = 2;
	private int lvl1wave3Mark = 3;

	private int lvl1wave1Amount = 5;//5 scout planes
	private int lvl1wave2Amount = 2;//2 medium planes
	private int lvl1wave3Amount = 1;//1 heavy plane



	//Level 2 has 3 waves
	private int lvl2wave1Mark = 4;
	private int lvl2wave2Mark = 5;
	private int lvl2wave3Mark = 6;


	private int lvl2wave1Amount = 10;//10 light planes
	private int lvl2wave2Amount = 10;// 7 scout planes, and 3 medium planes
	private int lvl2wave3Amount = 15;// 2 heavy planes, 6 light planes, and 7 scout planes



	//Level 3 has 4 waves








	//Level 4 has 1 waves







	// Use this for initialization
	void Start () 
	{

		//Outline  
		for (int i = 0; i < argoProjectiles.Length; i++) 
		{
			argoProjectiles[i] = (GameObject)Instantiate (goProjectilePrefab);
			argoProjectiles[i].SetActive (false);
		}


		//Enemy 1
		for (int i = 0; i < argoScouts.Length; i++) 
		{
			argoScouts[i] = (GameObject)Instantiate (goScoutPrefab);
			argoScouts[i].SetActive (false);
		}
		//Enemy 2
		for (int i = 0; i < argoLightEnems.Length; i++) 
		{
			argoLightEnems[i] = (GameObject)Instantiate (goLightEnemPrefab);
			argoLightEnems[i].SetActive (false);
		}
		//Enemy 3
		for (int i = 0; i < argoMediumEnems.Length; i++) 
		{
			argoMediumEnems[i] = (GameObject)Instantiate (goMediumEnemPrefab);
			argoMediumEnems[i].SetActive (false);
		}
		//Enemy 4
		for (int i = 0; i < argoHeavyEnems.Length; i++) 
		{
			argoHeavyEnems[i] = (GameObject)Instantiate (goHeavyEnemPrefab);
			argoHeavyEnems[i].SetActive (false);
		}




		//Randomize _WaypointStartScripti Somewhere in here.  Put anywhere!  












		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		//Randomize _WaypointUpdateScripti Somewhere in here.  Put anywhere!  
		

		if (Input.GetKey(KeyCode.Space)) //Just hold down to shoot
		{

			

		}
		
		//Destroy(temp);








		
	}



	//_Spawn Functions:  



	void SpawnObject () 
	{
		
		//Take the correct projectile
		GameObject go = argoProjectiles[iNext++];
		
		if (iNext >= argoProjectiles.Length) iNext = 0;
		
		//Fire the projectile
		go.SetActive (true);
		//go.rigidbody.velocity = Vector3.zero;
		go.transform.position = transform.position + transform.forward*10;
		go.transform.rotation = transform.rotation;
		go.rigidbody.velocity = transform.forward * fMag;
		//go.rigidbody.AddForce(transform.forward * fMag);
	}



	void SpawnScout () 
	{
		//Use SpawnObject outline





	}


	void SpawnLightEnemy () 
	{
		//Use SpawnObject outline





	}



	void SpawnMediumEnemy () 
	{
		//Use SpawnObject outline





	}





	void SpawnHeavyEnemy () 
	{
		//Use SpawnObject outline





	}







}

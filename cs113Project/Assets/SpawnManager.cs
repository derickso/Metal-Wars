﻿using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	private const float POSITION_RANGE = 250.0f;

	//Keeps the current wave number
	public int numberOfWaves;//Used to change it
	private static int sNumberOfWaves = 1;
	private static int currentWave = 0;
	private int objCurrentWave = 0; // Each instantiation specific current wave

	//Keeps the next wave time
	private static float nextWaveTime = 0.0f;
	private const float nextWaveDelay = 90.0f;

	//Keeps how many enemies are left in the current wave
	private static int numberOfEnemiesAlive = 0;

	//Number fo enemies per wave
	public int[] scoutsPerWave  	= new int[]{0}; 
	public int[] lightEnemsPerWave  = new int[]{0};
	public int[] mediumEnemsPerWave = new int[]{0};
	public int[] heavyEnemsPerWave 	= new int[]{0};

	//Prefabs
	//Scout
	public GameObject goScoutPrefab;
	private GameObject[] argoScouts;
	private int iNextScout = 0;
	//Light plane
	public GameObject goLightEnemyPrefab;
	private GameObject[] argoLightEnems;
	private int iNextLightEnemy = 0;
	//Medium plane
	public GameObject goMediumEnemyPrefab;
	private GameObject[] argoMediumEnems;
	private int iNextMediumEnemy = 0;
	//Heavy plane
	public GameObject goHeavyEnemyPrefab;
	private GameObject[] argoHeavyEnems;
	private int iNextHeavyEnemy = 0;

	// Use this for initialization
	void Start () {
	
		sNumberOfWaves = numberOfWaves;
		currentWave = 0;
		nextWaveTime = 0.0f;
		numberOfEnemiesAlive = 0;

		createEnemiesArgos();
		initEnemiesArgos();
	}

	//Initializes the enemies argos with their sizes
	private void createEnemiesArgos () {
		//inits the argo's with new game objects
		argoScouts 		= new GameObject[sumsOf(scoutsPerWave)];
		argoLightEnems 	= new GameObject[sumsOf(lightEnemsPerWave)];
		argoMediumEnems = new GameObject[sumsOf(mediumEnemsPerWave)];
		argoHeavyEnems 	= new GameObject[sumsOf(heavyEnemsPerWave)];
	}

	//Inits the enemies argos contents withe the prefabs
	private void initEnemiesArgos () {
		
		//Inits the argo contents with the correspondent game objects from the prefabs
		//Scouts
		for (int i=0; i< argoScouts.Length; ++i) 
		{
			argoScouts[i] = (GameObject)Instantiate (goScoutPrefab);
			argoScouts[i].SetActive (false);
		}
		//Light Enemies
		for (int i=0; i< argoLightEnems.Length; ++i)
		{
			argoLightEnems[i] = (GameObject)Instantiate (goLightEnemyPrefab);
			argoLightEnems[i].SetActive (false);
		}
		//Medium Enemies
		for (int i=0; i< argoMediumEnems.Length; ++i)
		{
			argoMediumEnems[i] = (GameObject)Instantiate (goMediumEnemyPrefab);
			argoMediumEnems[i].SetActive (false);
		}
		//Heavy Enemies
		for (int i=0; i< argoHeavyEnems.Length; ++i)
		{
			argoHeavyEnems[i] = (GameObject)Instantiate (goHeavyEnemyPrefab);
			argoHeavyEnems[i].SetActive (false);
		}
	}

	//gets the sum of all the contents into the array
	private int sumsOf (int[] array) {
		int result = 0;
		foreach (int i in array)
			result += i;
		return result;
	}
	
	// Update is called once per frame
	void Update () {

		//Updates the general wave
		updateWave();
		//updates the especific wave
		updateObjWave();

	}

	//Based in the static wave, each spawn point updates it's wave state
	private void updateObjWave () {
		//If it is not updated to the last wave, it spawns enemmies and increments its wave
		if(objCurrentWave < currentWave)
		{
			spawnEnemies();
			++objCurrentWave;
		}
	}

	//Spawns the enemeies of the objCurrentWave based in the number of enemies per wave
	private void spawnEnemies () {
		//Spwans Scouts
		for (int i=0; i<scoutsPerWave[objCurrentWave]; ++i)
			spawnEnemy(argoScouts[iNextScout++]);
		//Spawns Light enemies
		for (int i=0; i<lightEnemsPerWave[objCurrentWave]; ++i)
			spawnEnemy(argoLightEnems[iNextLightEnemy++]);
		//Spawns Medium enemies
		for (int i=0; i<mediumEnemsPerWave[objCurrentWave]; ++i)
			spawnEnemy(argoMediumEnems[iNextMediumEnemy++]);
		//Spawns Heavy enemies
		for (int i=0; i<heavyEnemsPerWave[objCurrentWave]; ++i)
			spawnEnemy(argoHeavyEnems[iNextHeavyEnemy++]);
	}

	//Spawns the enemy game object received
	private void spawnEnemy (GameObject go) {
		go.SetActive (true);
		go.transform.position.Set(
			Random.Range(transform.position.x-POSITION_RANGE,transform.position.x+POSITION_RANGE),
			Random.Range(transform.position.y-POSITION_RANGE,transform.position.y+POSITION_RANGE),
			Random.Range(transform.position.z-POSITION_RANGE,transform.position.z+POSITION_RANGE));
		//go.transform.rotation = transform.rotation;
		++numberOfEnemiesAlive;
	}

	//updates the current wave in a static way, so that all the spawn points knows
	//in which wave it is
	private static void updateWave () {
		//If the wave time is over, or all the enemies from the previous wave are dead
		if((currentWave < sNumberOfWaves)&&
		   ((numberOfEnemiesAlive < 0)||(Time.time > nextWaveTime)))
		{
			//Next wave time
			nextWaveTime = Time.time + nextWaveDelay;
			//Ressets the numberOfLivingEnemies variable
			numberOfEnemiesAlive = 0;
			//Increment the wave number
			++currentWave;
		}

	}
	
	//Decrements the number of enemies alive, so that the SpawnManager knows how many
	//are left in the current wave
	public static void decrementEnemiesAliveNumber () {
		--numberOfEnemiesAlive;

		//So that it symbolizes that the wave is over
		if(numberOfEnemiesAlive==0)
			--numberOfEnemiesAlive;
	}
}

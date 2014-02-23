using UnityEngine;
using System.Collections;

public class MiniMap : MonoBehaviour {


	public GameObject player;
	public float distanceBtwnMinimapViewAndObj;

	// Use this for initialization
	void Start () {
	
		//transform.position.x = player.transform.position.x;
		//transform.position.z = player.transform.position.z;
		transform.position = new Vector3(player.transform.position.x, distanceBtwnMinimapViewAndObj, player.transform.position.z);

	}
	
	// Update is called once per frame
	void Update () {
	

		transform.position = new Vector3(player.transform.position.x, distanceBtwnMinimapViewAndObj, player.transform.position.z);


	}
}

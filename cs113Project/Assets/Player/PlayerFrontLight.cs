using UnityEngine;
using System.Collections;

public class PlayerFrontLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		transform.position = new Vector3(0, 15.08865547f, 3.415879f);
		transform.Rotate(358.3416f, 0, 25);
		transform.localScale.Scale(new Vector3(5,5,5));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

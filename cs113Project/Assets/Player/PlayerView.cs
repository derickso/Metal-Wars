using UnityEngine;
using System.Collections;

public class PlayerView : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(0,15.5f,-3);
		transform.Rotate (0,0,0);
		transform.localScale.Scale(new Vector3(1,1,1));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

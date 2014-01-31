using UnityEngine;
using System.Collections;

public class LevelLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		transform.position = new Vector3(1000, 15000, 1000);
		transform.Rotate(50, 330, 0);
		transform.localScale.Scale(new Vector3(9000,9000,9000));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

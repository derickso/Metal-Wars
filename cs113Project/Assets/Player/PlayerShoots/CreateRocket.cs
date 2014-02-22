using UnityEngine;
using System.Collections;

public class CreateRocket : MonoBehaviour {

	public GameObject projectile;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			Instantiate (projectile, transform.position, transform.rotation);
		}
	}
}

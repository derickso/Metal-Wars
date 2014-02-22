using UnityEngine;
using System.Collections;

public class CreateRocket : MonoBehaviour {

	public GameObject projectile;

	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			Instantiate (projectile, transform.position, transform.rotation);
		}
	}
}

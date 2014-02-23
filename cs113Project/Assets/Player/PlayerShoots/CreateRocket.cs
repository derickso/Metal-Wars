using UnityEngine;
using System.Collections;

public class CreateRocket : MonoBehaviour {

	public GameObject projectile;
	public AudioClip missileFire;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			audio.PlayOneShot(missileFire, 0.5F);
			Instantiate (projectile, transform.position, transform.rotation);
		}
	}
}

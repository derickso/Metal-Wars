using UnityEngine;
using System.Collections;

public class CreateRocket : MonoBehaviour {

	public GameObject projectile;
	public AudioClip missileFire;
	public AudioClip sEMP;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			audio.PlayOneShot(missileFire, 0.50F);
			Instantiate (projectile, transform.position, transform.rotation);
		}

		if(Input.GetKey (KeyCode.E) && (Player.numEMPs > 0)) {
			audio.PlayOneShot (sEMP, 0.8F);
		}
	}
}

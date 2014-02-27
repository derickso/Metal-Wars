using UnityEngine;
using System.Collections;

public class MiniMap : MonoBehaviour {


	public GameObject playerObject;
	public float distanceBtwnMinimapViewAndObj;

	public float rotateSpeed = 25.0f;
	public float speed = 50.0f;


	// Use this for initialization
	void Start () {
	
		//transform.position.x = player.transform.position.x;
		//transform.position.z = player.transform.position.z;
		transform.position = new Vector3(playerObject.transform.position.x, distanceBtwnMinimapViewAndObj, playerObject.transform.position.z);

	}
	
	// Update is called once per frame
	void Update () {
	

		float transAmount = speed * Time.deltaTime;
		float rotateAmount = rotateSpeed * Time.deltaTime;

		transform.position = new Vector3(playerObject.transform.position.x, distanceBtwnMinimapViewAndObj, playerObject.transform.position.z);
		//transform.Rotate (0, 1, 0);
		//transform.rotation = new Quaternion(0, playerObject.transform.rotation.y, 0, 1);
		//transform.eulerAngles.y = playerObject.transform.eulerAngles.y;
		//transform.rotation = new Quaternion(0, playerObject.transform.eulerAngles.y, 0, 1);
		//transform.rotation = new Quaternion(0, playerObject.transform.rotation.z, 0, 1);

		if(Input.GetKey (KeyCode.A))
		{
			//transform.Rotate (0, 0, Player.rotateAmount);
			//transform.Rotate (0, 0, rotateAmount);
			//transform.Rotate (0, 0, playerObject.transform.rotation.y);
			//transform.Rotate (0, 0, playerObject.transform.eulerAngles.y);
			//transform.Rotate (0, 0, playerObject.transform.rotation.y * Time.deltaTime);
			//transform.Rotate (0, 0, playerObject.transform.rotation.y * rotateAmount);

		}
		if(Input.GetKey (KeyCode.D))
		{
			//transform.Rotate (0, 0, -Player.rotateAmount);
			//transform.Rotate (0, 0, -rotateAmount);
			//transform.Rotate (0, 0, -(playerObject.transform.rotation.y));
			//transform.Rotate (0, 0, -(playerObject.transform.eulerAngles.y));
			//transform.Rotate (0, 0, -(playerObject.transform.rotation.y * Time.deltaTime));
			//transform.Rotate (0, 0, -(playerObject.transform.rotation.y * rotateAmount));

		}


	}
}

using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	Rigidbody cameraRb;
	Camera cameraObj;
	public GameObject playerObj;
	public GameObject secPlayerObj;
	float maxY;

	// Use this for initialization
	void Start () {
		cameraRb = gameObject.GetComponent<Rigidbody> ();
		cameraObj = gameObject.GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Camera follows the player only at y-change
		//cameraRb.MovePosition (new Vector3(0f, playerObj.transform.position.y-1f,playerObj.transform.position.z-1f));
		if (playerObj.transform.position.y >= maxY || secPlayerObj.transform.position.y >= maxY) {
			maxY = playerObj.transform.position.y > secPlayerObj.transform.position.y 
				 ? playerObj.transform.position.y : secPlayerObj.transform.position.y;
		}

		cameraRb.MovePosition (new Vector3(0f, maxY,playerObj.transform.position.z-1f));

		//if player is outside the cameras view, set player to the other side
		if (playerObj.transform.position.x > cameraObj.orthographicSize*0.75f ||
			playerObj.transform.position.x < -cameraObj.orthographicSize*0.75f) {
			Debug.Log ("reached");
			playerObj.GetComponent<Rigidbody> ().MovePosition (new Vector3 (-playerObj.transform.position.x, playerObj.transform.position.y, playerObj.transform.position.z));
		}
	}
}

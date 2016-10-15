using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	GameObject playerObj;
	Rigidbody playerObjRb;
	public string left;
	public string right;

	// Use this for initialization
	void Start () {
		playerObj = gameObject;
		playerObjRb = playerObj.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (right))
			playerObjRb.AddForce (Vector3.right*10);


		if (Input.GetKey (left)) {
			playerObjRb.AddForce (-Vector3.right*10);
		}

	}
}

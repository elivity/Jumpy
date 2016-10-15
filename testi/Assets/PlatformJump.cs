using UnityEngine;
using System.Collections;

public class PlatformJump : MonoBehaviour {

	public Rigidbody gotPlayerRb;
	GameObject[] players;

	// Use this for initialization
	void Start () {
		players = GameObject.FindGameObjectsWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("ididit");
		//Debug.Log ("ididit");
		for (int i = 0; i < players.Length; i++) {
			if (other.name == players [i].name) {
				players[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
				players[i].GetComponent<Rigidbody>().AddForce (Vector3.up*700);
			}
		}



	}
}

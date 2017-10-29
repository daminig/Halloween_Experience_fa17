using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tjunctrigger : MonoBehaviour {
	public GameObject square;
	// Use this for initialization

	void onTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			square.GetComponent<Animation> ().Play ("t-junction");
			}
	}
	// Update is called once per frame

}

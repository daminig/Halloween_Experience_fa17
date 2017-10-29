using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tjunc : MonoBehaviour {

	public Animator anim;
	public GameObject square;
	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	//override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
	void Start() {
		anim = square.GetComponent<Animator>();
	}
	void OnTriggerEnter (Collider other) {

		//if (other.gameObject.tag == "Player") {
		//	square.GetComponent<Animator>().Play ("Cube");
		//}
		Debug.Log("hi");
		if (other.gameObject.tag == "Player") {
			anim.SetBool ("TriggerBool", true);
		}
	}
	// Update is called once per frame

}
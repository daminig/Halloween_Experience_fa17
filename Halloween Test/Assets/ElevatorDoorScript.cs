using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoorScript : MonoBehaviour {

        public Animator anim;
        public GameObject elevator_jamb;

	// Use this for initialization
	void Start () {
           anim = elevator_jamb.GetComponent<Animator>();   
	}
	
	// Update is called once per frame
	void Update () {
		
	}
        
        void OnTriggerEnter(Collider other) {
            anim.SetBool("CubeBool", true);
        }
        
}

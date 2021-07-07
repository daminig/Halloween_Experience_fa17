using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoorScript : MonoBehaviour {

        public Animator anim;
        public GameObject elevator;

	// Use this for initialization
	void Start () {
           anim = elevator.GetComponent<Animator>();   
	}
	
	// Update is called once per frame
	void Update () {
		
	}
        
        void OnTriggerEnter(Collider other) {
            anim.SetBool("CubeBool2", true);
        }
        
}

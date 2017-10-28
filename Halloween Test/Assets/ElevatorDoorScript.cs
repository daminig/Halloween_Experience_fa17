using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoorScript : MonoBehaviour {

        public Animation anim;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
        
        void OnTriggerEnter(Collider other) {
            anim.Play(); /*anim.clip.name*/
        }
}

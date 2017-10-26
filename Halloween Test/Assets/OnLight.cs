using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLight : MonoBehaviour {

	public Light light;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter (Collider other){
		light.enabled = !light.enabled;
		Invoke ("LightOff", 2);
	}

	void LightOff(){
		light.enabled = !light.enabled;
	}
}

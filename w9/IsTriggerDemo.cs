using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unityAnimation : MonoBehaviour {

	//OnTriggerEnter  : OnTriggerStay : OnTriggerExit
	void OnTriggerEnter(Collider other){
		GetComponent<Renderer> ().material.color = Color.cyan;
	}
	void OnTriggerStay(){
		transform.Rotate(Vector3.up, Time.deltaTime *30, Space.World);
	}
	void OnTriggerExit(Collider other){
		GetComponent<Renderer> ().material.color = Color.white;
	}
}

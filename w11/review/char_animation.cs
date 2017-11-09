using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mixamo_char_ani : MonoBehaviour {

	public Animator animation;

	void Start(){
		animation = GetComponent<Animator> ();
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			animation.SetBool ("turnAround", true);
			animation.SetBool ("turnBack", false);

		}
	}
	void OnTriggerExit(Collider other){
		if(other.gameObject.tag == "Player"){
			animation.SetBool ("turnAround", false);
			animation.SetBool ("turnBack", true);
		}
	}
}

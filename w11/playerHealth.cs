using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour {
	public static float pHealth = 5.0f;

	void OnCollisionEnter(Collision enemy){
		if(enemy.transform.tag == "Enemy"){
			pHealth -= 1.0f;
		}
		print (pHealth);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightChangeCollider : MonoBehaviour {                   
	public GameObject sun;
	private Color c = new Color(.5f, .0f, .0f);

	void OnTriggerEnter(){
		sun.GetComponent<Light>().intensity = 0.7f;
		sun.GetComponent<Light> ().color = c;
	}

	void OnTriggerExit(){
		sun.GetComponent<Light>().intensity = 1.1f;
		sun.GetComponent<Light> ().color = new Color(1,1, 1);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_navigation : MonoBehaviour {
	private float speed = 7.0f;

	void Update () {
		float r = Input.GetAxis ("Horizontal") *30* Time.deltaTime;
		transform.Rotate (Vector3.up, r , Space.Self);
		float z = Input.GetAxis ("Vertical") *Time.deltaTime*speed;
		transform.Translate (0, 0, z);
	}
}

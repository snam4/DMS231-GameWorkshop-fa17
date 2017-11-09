using UnityEngine;
using System.Collections;

public class lookAt : MonoBehaviour {
	public Transform target;
	Vector3 target_pos;

	// Update is called once per frame
	void Update () {
		target_pos = target.transform.position;
		target_pos.y = 0;

		transform.LookAt (target);
	}
}

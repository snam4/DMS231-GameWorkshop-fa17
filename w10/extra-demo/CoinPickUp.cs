using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {
	private GameObject player;
	public playerScore pScore;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		pScore = player.GetComponent<playerScore> ();
	}
	void Update(){
		transform.Rotate (Vector3.up, Time.deltaTime * 20, Space.World);
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			pScore.score++;
			Destroy (gameObject);	
		}
	}
}

//https://docs.unity3d.com/2017.3/Documentation/ScriptReference/GUIText.html
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiDisplay : MonoBehaviour {
	float pHealth = 0.0f;
	//float coin = 0.0f;
	//GUITexture myTexture;

	void OnGUI(){
		pHealth = playerHealth.pHealth;
		string eHealthText = pHealth.ToString ();

		GUI.Box (new Rect (10,10, 150, 50),"PLAYER HEALTH");
		GUI.Label (new Rect (75, 30, 25, 25), eHealthText);

		//coin = coinCount.score;
		//string coinText = coin.ToString ();

		//GUI.Label (new Rect (170, 60, 25, 25), coinText);
		//GUI.Box (new Rect (120,10, 100, 100),"Coin");
	}

}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextUpdate : MonoBehaviour {

	Text txt;
	private float PageNumber;
	
	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>(); 

	}

//	void Update (){
//		WhatPage ();
//		txt.text="PAGE " + PageNumber + " of 32";
//	}
	
//	//What Page is this?
//	void WhatPage() {
//		GameObject thePlayer = GameObject.Find("Page");
//		controller playerScript = thePlayer.GetComponent<controller>();
//		PageNumber = playerScript.pageNum;
//	}
}

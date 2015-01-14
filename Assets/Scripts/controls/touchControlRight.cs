using UnityEngine;
using System.Collections;


public class touchControlRight : MonoBehaviour {

	public void OnMouseDown(){
		
		GameObject go = GameObject.Find("Page");
		go.GetComponent<controller>().Forward();
		
	}

	
	
	public void goRight(){

		GameObject go = GameObject.Find("Page");
		go.GetComponent<controller>().Forward();

	}

}



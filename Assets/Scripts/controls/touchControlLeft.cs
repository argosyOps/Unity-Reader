using UnityEngine;
using System.Collections;

public class touchControlLeft : MonoBehaviour {


	public void OnMouseDown(){
		
		GameObject go = GameObject.Find("Page");
		go.GetComponent<controller>().Backward();
		
	}

	public void goLeft(){
		GameObject go = GameObject.Find("Page");
		go.GetComponent<controller>().Backward();
	}


	}




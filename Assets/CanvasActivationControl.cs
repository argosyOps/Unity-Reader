using UnityEngine;
using System.Collections;

public class CanvasActivationControl : MonoBehaviour {


	//Disable canvas
	public void DisableCanvas() {
		gameObject.SetActive(false);
	}

	//Enable canvas
	public void EnableCanvas() {
		gameObject.SetActive(true);
	}
}

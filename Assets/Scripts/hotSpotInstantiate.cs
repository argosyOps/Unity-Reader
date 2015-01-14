using UnityEngine;
using System.Collections;

public class hotSpotInstantiate : MonoBehaviour {

	public GameObject HotSpotPrefab;
	public Transform hotSpotPosition;


	void Update(){
//		if (GameObject.Find("WhateverItsCalled") != null)
//		{
//			Destroy (gameObject);
//		}

	}

	// Use this for initialization
	public void HotSpotCreate() {
		if (GameObject.Find ("HotSpotPrefab(Clone)") == null) {
			Instantiate (HotSpotPrefab, new Vector3(hotSpotPosition.position.x, hotSpotPosition.position.y, -150), hotSpotPosition.rotation);
				}
	}
	

}

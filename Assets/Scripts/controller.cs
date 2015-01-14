using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

	string playing = null;
	static int Direction = 2;
	private float cameraZoom;
	float aniLength = 0;

	public int pageNum = 0;
	public int portraitTrigger;



	void Start () {
		

		playing = animation.clip.name;
		Length ();
		
		
		if (Direction == 1) {
			
			animation[playing].time = aniLength;
			Backward ();
		}

	}
	

	// Update is called once per frame
	void Update () {
		

		WhatPage ();
		
		//Controls
		if (Input.GetKeyDown ("left")) {
			Backward();
		}
		
		if (Input.GetKeyDown ("right")) {
			Forward();
		}
		
		//End of frame trigger
		if (animation[playing].normalizedTime >= 0.90F && Direction == 2) {
			audioFadeOut();
		}

		//End of frame audio fade out
		if (animation[playing].normalizedTime >= 0.99F && Direction == 2) {
			nextPage();
		}
		
		// Turn off change scene camera size based trigger
		if (cameraZoom >= 8.87 && portraitTrigger == 1) {


		}

		//Control if animation is player

		foreach (AnimationState state in animation) {
			if (state.speed == 1.0f || state.speed <= -1.0f) {
				GameObject go = GameObject.Find ("CanvasNav");
								go.GetComponent<touchControlCenter> ().moving ();
			} 
				}


		
	}
	
	void FixedUpdate() {

		cameraZoom = Camera.main.orthographicSize;

		// Change scene camera size based trigger

		if ( portraitTrigger == 1 && cameraZoom <= 8.87f ) {
			portraitTriggerZoomOut();
		}

		// Change scene camera size based trigger

		if ( portraitTrigger == 0 && cameraZoom >= 4.82f ) {
			portraitTriggerZoomIn();
		}
		
		
	}



	public void Stopper() {
		//Stopping Script
		foreach (AnimationState state in animation) {
			state.speed = 0F;
			Direction = 0;
		}

		GameObject go = GameObject.Find ("CanvasNav");
		go.GetComponent<touchControlCenter> ().NotMoving ();



	}


	//Start Frame event
	void frameStart() {

		if (Direction == 1) {
			lastPage();
		}
	}
	
	
	


	public void Backward() {
		foreach (AnimationState state in animation) {
			state.speed = -3.0F;
			Direction = 1;

			if (GameObject.Find("HotSpotPrefab(Clone)") != null )
			{
				GameObject Hot = GameObject.Find("HotSpotPrefab(Clone)");
				Hot.GetComponent<hotSpot>().fadeOutani();
			}
		}
	}

	public void Forward() {
		foreach (AnimationState state in animation) {
			state.speed = 1.0F;
			Direction = 2;

			//Activate hot spots only moving forward
			if (GameObject.Find("HotSpotPrefab(Clone)") != null )
			{
				GameObject Hot = GameObject.Find("HotSpotPrefab(Clone)");
				Hot.GetComponent<hotSpot>().fadeOutani();
			}

		}
	}
	
	//Page Transition Audio Fadeout
	void audioFadeOut() {
		GameObject fadingAudio = GameObject.Find ("Page");
		fadingAudio.GetComponent<audioPlay> ().background1_fadeout();
		fadingAudio.GetComponent<audioPlay> ().background2_fadeout();
	}


	//Page Transition next page
	void nextPage() {

		GameObject[] pageElements = GameObject.FindGameObjectsWithTag("Page");
		foreach (GameObject pageElement in pageElements) {
			Destroy (pageElement);
			
		}


		Destroy (GameObject.FindWithTag("Audio"));
		Destroy (GameObject.FindWithTag("HotSpot"));


		GameObject comicPrefab = (GameObject)(Resources.Load("scoliosis"));

		GameObject pageFind = comicPrefab.transform.Find("page" + (pageNum + 1)).gameObject;
		
		GameObject page = (GameObject)Instantiate(pageFind);


		page.name = page.name.Replace("(Clone)", "");


	}

	//Page Transition previous page
	void lastPage() {

		GameObject[] pageElements = GameObject.FindGameObjectsWithTag("Page");
		
		foreach (GameObject pageElement in pageElements) {
			Destroy (pageElement);
			
		}


		Destroy (GameObject.FindWithTag("Audio"));
		Destroy (GameObject.FindWithTag("HotSpot"));

		GameObject comicPrefab = (GameObject)(Resources.Load("scoliosis"));
		
		GameObject pageFind = comicPrefab.transform.Find("page" + (pageNum - 1)).gameObject;
		
		GameObject page = (GameObject)Instantiate(pageFind);

		page.name = page.name.Replace("(Clone)", "");



	}

	//Page Transition to a page number elected by the thumb menu and called by the buttonClickControl script to pageNum
	public void loadPage() {


		GameObject[] pageElements = GameObject.FindGameObjectsWithTag("Page");
		
		foreach (GameObject pageElement in pageElements) {
			Destroy (pageElement);
			
		}
		
		
		Destroy (GameObject.FindWithTag("Audio"));
		Destroy (GameObject.FindWithTag("HotSpot"));
		
		GameObject comicPrefab = (GameObject)(Resources.Load("scoliosis"));
		
		GameObject pageFind = comicPrefab.transform.Find("page" + (pageNum)).gameObject;
		
		GameObject page = (GameObject)Instantiate(pageFind);
		
		page.name = page.name.Replace("(Clone)", "");

		if (GameObject.Find("HotSpotPrefab(Clone)") != null )
		{
			GameObject Hot = GameObject.Find("HotSpotPrefab(Clone)");
			Hot.GetComponent<hotSpot>().fadeOutani();
		}
		
		Direction = 2;
		
	}

	//Length of Clip
	void Length() {
		aniLength = animation[playing].length;

	}

	//Generate HotSpot
	public void HotSpotCreation(){
		if (Direction == 2) {
						GameObject hot = GameObject.Find ("Hot Spot Placement");
						hot.GetComponent<hotSpotInstantiate> ().HotSpotCreate ();
				}
		}

	//Portrait Trigger Turn on
	public void portraitTriggerOn() {

		//Trigger Portrait mode
		if (Input.deviceOrientation == DeviceOrientation.Portrait || Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown || Input.GetKeyDown ("p")) {
						portraitTrigger = 1;
						Debug.Log ("on");
			GameObject navOn = GameObject.Find ("Main Camera");
			navOn.GetComponent<orientation> ().UsePortraitLayoutZoomOut ();

		} else if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight || Input.GetKeyDown ("l")) {
			portraitTrigger = 0;
			Debug.Log ("off");

		}




	}

	public void portraitTriggerOff() {
		
		//Trigger Portrait mode
		portraitTrigger = 0;
//		Debug.Log ("off Portrait mode");
		GameObject navOn = GameObject.Find ("Main Camera");
		navOn.GetComponent<orientation> ().UsePortraitLayout ();
	}


	//Portrait Trigger Camera Zoom Out
	void portraitTriggerZoomOut() {
		Camera.main.orthographicSize += 16f * Time.deltaTime;

	}

	//Landscape Trigger Camera Zoom Out
	void portraitTriggerZoomIn() {
		Camera.main.orthographicSize -= 16f * Time.deltaTime;
		
	}

	//What Page is this?
	void WhatPage() {
//		GameObject thePlayer = GameObject.Find("Page");
//		controller playerScript = thePlayer.GetComponent<controller>();
		//Debug.Log (playerScript.pageNum);
	}




}
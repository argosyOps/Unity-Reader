using UnityEngine;
using System.Collections;

public class orientation : MonoBehaviour {

	public int width;
	public int portraitTrigger;

//	private GameObject leftPort;
//	private GameObject centPort;
//	private GameObject rightPort;
//
//	private GameObject leftPortZoomOut;
//	private GameObject centPortZoomOut;
//	private GameObject rightPortZoomOut;
//
//	private GameObject leftLand;
//	private GameObject centLand ;
//	private GameObject rightLand;


	void Start(){

//		leftPort = GameObject.Find("leftNavigatePortrait");
//		centPort = GameObject.Find("centerNavigatePortrait");
//		rightPort = GameObject.Find("rightNavigatePortrait");
//		
//		leftPortZoomOut = GameObject.Find("leftNavigatePortraitZoomOut");
//		centPortZoomOut = GameObject.Find("centerNavigatePortraitZoomOut");
//		rightPortZoomOut = GameObject.Find("rightNavigatePortraitZoomOut");
//		
//		leftLand = GameObject.Find("leftNavigateLandscape");
//		centLand = GameObject.Find("centerNavigateLandscape");
//		rightLand = GameObject.Find("rightNavigateLandscape");

	}
	
	// Update is called once per frame
	void Update () {

		// Change scene camera size based on orientation
		if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight || Input.GetKeyDown ("l")) {
			UseLandscapeLeftLayout();
		}
		else if (Input.deviceOrientation == DeviceOrientation.Portrait || Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown || Input.GetKeyDown ("p")  ) {
			UsePortraitLayout();

		} 



	}



	public void UsePortraitLayout(){
	//	Camera.main.orthographicSize = 9.54F;

//		// Portrait
//		leftPort.collider.enabled=true;
////		leftPort.renderer.enabled=true;
//		centPort.collider.enabled=true;
//		//		leftPort.renderer.enabled=true;
//		rightPort.collider.enabled=true;
////		rightPort.renderer.enabled=true;
//
//
//		//Portrait Zoom Out
//		leftPortZoomOut.collider.enabled=false;
//
//
//		centPortZoomOut.collider.enabled=false;
//
//		rightPortZoomOut.collider.enabled=false;
//
//
//		//Landscape
//
//		leftLand.collider.enabled=false;
////		leftLand.renderer.enabled=false;
//		centLand.collider.enabled=false;
//		//		leftLand.renderer.enabled=false;
//		rightLand.collider.enabled=false;
////		rightLand.renderer.enabled=false;



	}

	public void UseLandscapeLeftLayout(){
//	//	Camera.main.orthographicSize = 4.82F;
//
//		// Portrait
//		leftPort.collider.enabled=false;
//	//	leftPort.renderer.enabled=false;
//		centPort.collider.enabled=false;
//		//		leftPort.renderer.enabled=false;
//		rightPort.collider.enabled=false;
//	//	rightPort.renderer.enabled=false;
//
//		//Portrait Zoom Out
//		leftPortZoomOut.collider.enabled=false;
//		centPortZoomOut.collider.enabled=false;
//		rightPortZoomOut.collider.enabled=false;
//	
//
//		//Landscape
//		leftLand.collider.enabled=true;
//	//	leftLand.renderer.enabled=true;
//		centLand.collider.enabled=true;
//		//		leftLand.renderer.enabled=true;
//		rightLand.collider.enabled=true;
//	//	rightLand.renderer.enabled=true;



	}

	public void UsePortraitLayoutZoomOut(){
//		//	Camera.main.orthographicSize = 4.82F;
//		
//		// Portrait
//		leftPort.collider.enabled=false;
//		//	leftPort.renderer.enabled=false;
//		centPort.collider.enabled=false;
//		//		leftPort.renderer.enabled=false;
//		rightPort.collider.enabled=false;
//		//	rightPort.renderer.enabled=false;
//		
//		//Portrait Zoom Out
//		leftPortZoomOut.collider.enabled=true;
//		centPortZoomOut.collider.enabled=true;
//		rightPortZoomOut.collider.enabled=true;
//
//
//		//Landscape
//		leftLand.collider.enabled=false;
//		//	leftLand.renderer.enabled=false;
//		centLand.collider.enabled=false;
//		//		leftLand.renderer.enabled=false;
//		rightLand.collider.enabled=false;
//		//	rightLand.renderer.enabled=false;
		
		
		
	}




}

using UnityEngine;
using System.Collections;

public class raycaster : MonoBehaviour {

	public int PortraitPublic;
	RaycastHit hit;
	private string other;
	private GameObject panelHit;
	private RaycastHit hitInfo = new RaycastHit();

	void Update() {

		Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;
		Debug.DrawRay(transform.position, forward, Color.green);


		RaycastHit[] allHits;
		allHits = Physics.RaycastAll(transform.position, forward, 10000);
		foreach (var hits in allHits)
		{

			if (hits.collider.gameObject.tag == "Page") {

				other = hits.collider.gameObject.name;

				 panelHit = GameObject.Find(other);

				raycastHit ();

			} 
		}


		//Raycast Return Object via tag to load menu for all paltforms expect ios and android ensuring center nav clicked
		if (Input.GetMouseButtonDown(0))
		{
		
			if (Application.platform != RuntimePlatform.IPhonePlayer && Application.platform != RuntimePlatform.Android){

				bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
				if (hit) 
				{
				//	Debug.Log("Hit " + hitInfo.transform.gameObject.name);
					if (hitInfo.transform.gameObject.tag == "centerNav")
					{

						GameObject Hot = GameObject.Find ("SubMenu");
						Hot.GetComponent<SlideOut> ().TriggerInSubMenu ();
						
						//						GameObject Hot = GameObject.Find ("Page Menu");
//						Hot.GetComponent<SlideOut> ().TriggerIn ();
					} else {
					//	Debug.Log ("nopz");
					}
				} else {
				//	Debug.Log("No hit");
				}
			}

		} 
		//end of code

	}
		

	void raycastHit() {

		//Get value of gameobject in raycast collision

	//	Debug.Log (panelHit.GetComponent<cameraOrientation> ().Portrait);


		PortraitPublic = panelHit.GetComponent<cameraOrientation> ().Portrait;



		if (PortraitPublic == 1) {
			
			GameObject hitActive = GameObject.Find ("Page");
			hitActive.GetComponent<controller> ().portraitTriggerOn();
//			Debug.Log ("Portait Public On");

				}

		if (PortraitPublic == 0) {
			
			GameObject hitActive = GameObject.Find ("Page");
			hitActive.GetComponent<controller> ().portraitTriggerOff();
	//		Debug.Log ("Portait Public Off");
			
		}
	}


	}


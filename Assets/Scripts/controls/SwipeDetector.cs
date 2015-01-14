using UnityEngine;
using System.Collections;

public class SwipeDetector : MonoBehaviour {
	
	public float minSwipeDistY = 160;
	
	public float minSwipeDistX = 160;
	
	private Vector2 startPos;
	
	private GameObject menuCenter;
	
	//Swipe code


	
	void Update()
	{
		//#if UNITY_ANDROID
		if (Input.touchCount > 0) 
			
		{
			
			
			//Resume swipe script
			
			Touch touch = Input.touches[0];
			
			
			
			switch (touch.phase) 
				
			{
				
			case TouchPhase.Began:
				
				startPos = touch.position;
				
				
				
				break;
				
				
				
			case TouchPhase.Ended:
				
				float swipeDistVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;
				
				if (swipeDistVertical > minSwipeDistY) 
					
				{
					
					float swipeValue = Mathf.Sign(touch.position.y - startPos.y);
					
					if (swipeValue > 0)//up swipe
					{	
						//Jump ();
					}	
					else if (swipeValue < 0)//down swipe
					{
						//Shrink ();
					}		
				}
				
				float swipeDistHorizontal = (new Vector3(touch.position.x,0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;
				
				if (swipeDistHorizontal > minSwipeDistX) 
					
				{
					
				
							//If swipe occurs then no menu is triggered
							GameObject Hot = GameObject.Find ("Page Menu");
							Hot.GetComponent<SlideOut> ().TriggerOut ();

					GameObject SubOut = GameObject.Find ("SubMenu");
					SubOut.GetComponent<SlideOut> ().TriggerOutSubMenu ();
							//
							
							float swipeValue = Mathf.Sign(touch.position.x - startPos.x);
							
							
							
							if (swipeValue > 0)//right swipe
							{
								
								GameObject go = GameObject.Find("Page");
								go.GetComponent<controller>().Backward();
								//MoveRight ();
							}	
							else if (swipeValue < 0)//left swipe
							{		
								GameObject go = GameObject.Find("Page");
								go.GetComponent<controller>().Forward();
								//MoveLeft ();
							}	
							
							
						
					
					
					
				} else if (swipeDistHorizontal < minSwipeDistX-150){
					//If no swipe occurs then  menu is triggered ensuring finger is over the center navigation
					RaycastHit hitInfo = new RaycastHit();
					bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
					if (hit) 
					{
						Debug.Log("Hit " + hitInfo.transform.gameObject.name);
						if (hitInfo.transform.gameObject.tag == "centerNav")
						{
							GameObject SubOut = GameObject.Find ("SubMenu");
							SubOut.GetComponent<SlideOut> ().TriggerInSubMenu ();
							
							//							GameObject Hot = GameObject.Find ("Page Menu");
							//							Hot.GetComponent<SlideOut> ().TriggerIn ();
						} else {
							Debug.Log ("nopz");
						}
					} else {
						Debug.Log("No hit");
					}
					
				}
				break;
			}
		}
	}
}


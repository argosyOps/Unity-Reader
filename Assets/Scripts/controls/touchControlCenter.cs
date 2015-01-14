using UnityEngine;
using System.Collections;

public class touchControlCenter : MonoBehaviour {

	public int Moving;


	void Start() {

			Moving = 1;
	}
	
	public void ActivateSubMenu(){
		GameObject subMenu = GameObject.Find ("SubMenu");
		subMenu.GetComponent<SlideOut> ().TriggerInSubMenu ();

		GameObject panelNavigation = GameObject.Find ("PanelNav");
		panelNavigation.GetComponent<CanvasActivationControl> ().DisableCanvas ();

		
	}

	public void moving(){
		
	
		Moving = 1;
		
		
	}



	public void NotMoving(){

		Moving = 0;

	}
	


}

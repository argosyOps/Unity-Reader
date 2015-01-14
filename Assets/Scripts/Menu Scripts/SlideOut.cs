using UnityEngine;
using System.Collections;

public class SlideOut : MonoBehaviour {
	
	protected Animator animator;
	private GameObject[] centerNavs;
	private GameObject[] landscapeNavs;
	private GameObject[] portraitNavs;
	private GameObject[] hotspotInteractives;
	private GameObject panelNavigation;
	private GameObject canvasNavigation;


	
	void Start() {
		
		//Set up arrays of objects based on TAG
		centerNavs = GameObject.FindGameObjectsWithTag("centerNav");
		landscapeNavs = GameObject.FindGameObjectsWithTag("Landscape");
		portraitNavs = GameObject.FindGameObjectsWithTag("Portrait");

		panelNavigation = GameObject.Find ("PanelNav");

		canvasNavigation = GameObject.Find ("CanvasNav");
		
		
	}
	
	public void TriggerOut(){

		hotspotInteractives = GameObject.FindGameObjectsWithTag ("HotSpot");
		
		//Turn back on raycast layer for nav
		
		

		
		foreach (GameObject centerNav in centerNavs) {
			centerNav.layer = LayerMask.NameToLayer ("Default");
			
		}
		
		
		
		foreach (GameObject landscapeNav in landscapeNavs) {
			landscapeNav.layer = LayerMask.NameToLayer ("Default");
			
		}
		
		
		
		foreach (GameObject portraitNav in portraitNavs) {
			portraitNav.layer = LayerMask.NameToLayer ("Default");
			
		}

		foreach (GameObject hotspotInteractive in hotspotInteractives) {
			hotspotInteractive.layer = LayerMask.NameToLayer ("Default");
			
		}
		
		//Play aniamtion
		
		animator = GetComponent<Animator> ();
		animator.SetBool ("SlideIn", false);
		animator.SetBool ("SlideOut", true);
	}
	
	public void TriggerIn(){
		GetComponent<Animator>().enabled = true;

		hotspotInteractives = GameObject.FindGameObjectsWithTag("HotSpot");
		
		//Set Layer to ignore raycast
		

		
		foreach (GameObject centerNav in centerNavs) {
			centerNav.layer = LayerMask.NameToLayer ("Ignore Raycast");
			
		}
		
		foreach (GameObject landscapeNav in landscapeNavs) {
			landscapeNav.layer = LayerMask.NameToLayer ("Ignore Raycast");
			
		}
		
		foreach (GameObject portraitNav in portraitNavs) {
			portraitNav.layer = LayerMask.NameToLayer ("Ignore Raycast");
			
		}

		foreach (GameObject hotspotInteractive in hotspotInteractives) {
			hotspotInteractive.layer = LayerMask.NameToLayer ("Ignore Raycast");
			
		}
		
		
		
		animator = GetComponent<Animator> ();
		animator.SetBool ("SlideOut", false);
		animator.SetBool ("SlideIn", true);
		
		
		//Page thumbnails animation load in
		GameObject Hot = GameObject.Find("Cover");
		Hot.GetComponent<buttonClickControl>().appear();
	}
	
	// Slide in sub menu
	public void TriggerInSubMenu(){
		
		hotspotInteractives = GameObject.FindGameObjectsWithTag("HotSpot");

		//Set Layer to ignore raycast
		
		
		foreach (GameObject centerNav in centerNavs) {
			centerNav.layer = LayerMask.NameToLayer ("Ignore Raycast");
			
		}
		
		foreach (GameObject landscapeNav in landscapeNavs) {
			landscapeNav.layer = LayerMask.NameToLayer ("Ignore Raycast");
			
		}
		
		foreach (GameObject portraitNav in portraitNavs) {
			portraitNav.layer = LayerMask.NameToLayer ("Ignore Raycast");
			
		}

		foreach (GameObject hotspotInteractive in hotspotInteractives) {
			hotspotInteractive.layer = LayerMask.NameToLayer ("Ignore Raycast");
			
		}
		
		
		//play animation
		animator = GetComponent<Animator> ();
		animator.SetBool ("slide out", false);
		animator.SetBool ("slide in", true);
		
		
	}
	
	// Slide out sub menu
	public void TriggerOutSubMenu(){


		panelNavigation.GetComponent<CanvasActivationControl> ().EnableCanvas ();

		hotspotInteractives = GameObject.FindGameObjectsWithTag("HotSpot");
		
		//Set Layer to ignore raycast
		
		
		foreach (GameObject centerNav in centerNavs) {
			centerNav.layer = LayerMask.NameToLayer ("Default");
			
		}
		
		
		
		foreach (GameObject landscapeNav in landscapeNavs) {
			landscapeNav.layer = LayerMask.NameToLayer ("Default");
			
		}
		
		
		
		foreach (GameObject portraitNav in portraitNavs) {
			portraitNav.layer = LayerMask.NameToLayer ("Default");
			
		}

		foreach (GameObject hotspotInteractive in hotspotInteractives) {
			hotspotInteractive.layer = LayerMask.NameToLayer ("Default");
			
		}
		
		
		//play animation
		animator = GetComponent<Animator> ();
		animator.SetBool ("slide out", true);
		animator.SetBool ("slide in", false);
		
		
	}
	
	public void activateThumbnailMenu(){
		
		TriggerOutSubMenu ();

		canvasNavigation.GetComponent<CanvasActivationControl> ().DisableCanvas ();
		panelNavigation.GetComponent<CanvasActivationControl> ().DisableCanvas ();
		
		GameObject Hot = GameObject.Find ("Page Menu");
		Hot.GetComponent<SlideOut> ().TriggerIn ();
		
		
	}
	
	public void ActivatePageMenu(){
		
		GetComponent<Animator>().enabled = true;
		
		GameObject SubMenu = GameObject.Find ("SubMenu");
		SubMenu.GetComponent<SlideOut> ().TriggerOutSubMenu ();
		
		
		
		foreach (GameObject centerNav in centerNavs) {
			centerNav.layer = LayerMask.NameToLayer ("Ignore Raycast");
			
		}
		
		
	}
	
	public void ActivateMidNav(){
		
		
		//Set Layer to ignore raycast
		
		
		foreach (GameObject centerNav in centerNavs) {
			centerNav.layer = LayerMask.NameToLayer ("Default");
			
		}

		
	}

	public void inactivateMainNav() {
		foreach (GameObject centerNav in centerNavs) {
			centerNav.layer = LayerMask.NameToLayer ("Ignore Raycast");
			
		}
		
		foreach (GameObject landscapeNav in landscapeNavs) {
			landscapeNav.layer = LayerMask.NameToLayer ("Ignore Raycast");
			
		}
		
		foreach (GameObject portraitNav in portraitNavs) {
			portraitNav.layer = LayerMask.NameToLayer ("Ignore Raycast");
			
		}


		canvasNavigation.GetComponent<CanvasActivationControl> ().EnableCanvas ();
		panelNavigation.GetComponent<CanvasActivationControl> ().EnableCanvas ();

	}
	
	public void Deactive(){
		canvasNavigation.GetComponent<CanvasActivationControl> ().DisableCanvas ();
		panelNavigation.GetComponent<CanvasActivationControl> ().DisableCanvas ();
	}

	public void Activate(){
		canvasNavigation.GetComponent<CanvasActivationControl> ().EnableCanvas ();
		panelNavigation.GetComponent<CanvasActivationControl> ().EnableCanvas ();
	}
	
}
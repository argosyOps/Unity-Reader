using UnityEngine;
using System.Collections;

public class buttonClickControl : MonoBehaviour {


	public int pageNum;
	private float PageNumber;
	private GameObject thePageNum;
	private GameObject[] thumbnails;


	// Use this for initialization
	void Start () {
//		disappear ();



	}


	void Update () {
		SelectThumb ();
	}

//Clicked thumbnail animation play

	public void click() {
		Destroy (GameObject.FindWithTag("HotSpot"));
		//Plays selected animation and changes tag to prevent normal thumbnail dissappearing animation triggered by the timeline
		Debug.Log ("click"); 
		animation.Play("selected");
		gameObject.tag = "Selected";


		//Change Page Number of controller on page object
		GameObject Hot = GameObject.Find("Page");
		controller theScript  = Hot.GetComponent<controller>();
		theScript.pageNum = pageNum;
		Hot.GetComponent<controller> ().loadPage ();



	}

	public void clickReturn() {

				//Plays selected animation and changes tag to prevent normal thumbnail dissappearing animation triggered by the timeline
				Debug.Log ("click"); 
				animation.Play ("selected");
				gameObject.tag = "Selected";

		}

	//Build in Animate and move thumbnails after selecting one
	public void appear() {
		
		GameObject[] thumbnails = GameObject.FindGameObjectsWithTag("thumbnail");
		
		foreach (GameObject thumbnail in thumbnails) {
			thumbnail.animation.Play("appear");

		}
		
	}

	//Animate and move thumbnails after selecting one
	public void disappear() {

		GameObject[] thumbnails = GameObject.FindGameObjectsWithTag("thumbnail");

		foreach (GameObject thumbnail in thumbnails) {
			thumbnail.animation.Play("disappear");
			gameObject.tag = "thumbnail";
		
		}

		GameObject Hot = GameObject.Find("Page Menu");
		Hot.GetComponent<SlideOut>().TriggerOut();



}

	//Animate and move thumbnails after selecting one
	public void disappearSettings() {
		
	
		GameObject Hot = GameObject.Find("Settings");
		Hot.GetComponent<SlideOut>().TriggerOut();
		
		
		
	}

	public void SelectThumb(){
		//Find page number and highlight thumbnail
		thumbnails = GameObject.FindGameObjectsWithTag("thumbnail");
		thePageNum = GameObject.Find("Page");
		
		controller playerScript = thePageNum.GetComponent<controller>();
		PageNumber = playerScript.pageNum;

		//Highlight thumb of current page
		foreach (GameObject thumbnail in thumbnails) {
			
			if(thumbnail.name == "page" + PageNumber)
				thumbnail.transform.localScale = new Vector3(0.85F, .85F, .85F);




		}
	}



}
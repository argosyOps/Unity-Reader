using UnityEngine;
using System.Collections;

public class hotSpot : MonoBehaviour {

	Animator anim;
	int fadeOut = Animator.StringToHash("fadeOut");


	void Start ()
	{
		anim = GetComponent<Animator>();
	}


	public void fadeOutani(){
		anim.SetTrigger (fadeOut);

	
	} 

	public void destroy() {
		Destroy (gameObject);

		GameObject SubMenu = GameObject.Find ("SubMenu");
		SubMenu.GetComponent<SlideOut> ().Activate ();

	}

	 void OnMouseDown(){
		fadeOutani();
		audio.Play();
		GameObject SubMenu = GameObject.Find ("SubMenu");
		SubMenu.GetComponent<SlideOut> ().Deactive ();

		anim.speed = 3;
		}


}

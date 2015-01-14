using UnityEngine;
using System.Collections;

public class loading : MonoBehaviour {

	public int numPageNumber;

	// Use this for initialization
	void Start () {
		Example ();
	}
	

	void Example() {

				Application.LoadLevel ("control");
				Application.LoadLevelAdditive ("page1");
		}



}

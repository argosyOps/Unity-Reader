using UnityEngine;
using System.Collections;

public class loading_prefab : MonoBehaviour {

	public int numPageNumber;
	 


	// Use this for initialization
	void Start () {

		//Camera and Navigation Prefabs
		GameObject camera = (GameObject)Instantiate(Resources.Load("Camera&Nav2"));

		//Comic Load
		GameObject comicPrefab = (GameObject)(Resources.Load("scoliosis"));

		//Load First Page of Comic
		GameObject pageFind = comicPrefab.transform.Find("page2").gameObject;

		GameObject page = (GameObject)Instantiate(pageFind);

		//Load Sub Menu
		GameObject SubMenu = (GameObject)Instantiate(Resources.Load("SubMenu"));

		//Load Page Menu
		GameObject PageMenu = (GameObject)Instantiate(Resources.Load("Page Menu"));

		//Settings Menu
		GameObject Settings = (GameObject)Instantiate(Resources.Load("Settings"));




		//Remove Clone name
		page.name = page.name.Replace("(Clone)", "");
		camera.name = camera.name.Replace("(Clone)", "");
		PageMenu.name = PageMenu.name.Replace("(Clone)", "");
		SubMenu.name = SubMenu.name.Replace("(Clone)", "");
		Settings.name = Settings.name.Replace("(Clone)", "");

	}




	


}

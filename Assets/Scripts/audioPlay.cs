using UnityEngine;
using System.Collections;

public class audioPlay : MonoBehaviour {

	public GameObject soundEffect1;
	public GameObject soundEffect2;
	public GameObject soundEffect3;
	public GameObject soundEffect4;
	public GameObject soundEffect5;

	public GameObject background1;
	public GameObject background2;

	
	//Background1
	 float background1_vol = 1.0f;
	 int background1_fadeout_active = 0;

	//Background2
	float background2_vol = 1.0f;
	int background2_fadeout_active = 0;



	void Start() {
		background1 = GameObject.Find("background1");
		background2 = GameObject.Find("background2");

	}


	void Update(){

		//Handle background1 fade out


		background1.audio.volume = background1_vol;
		if (background1.audio.volume > 0 && background1_fadeout_active == 1) {
			background1_vol_fadeout ();
				} 
		if (background1.audio.volume <= 0) {
			background1_fadeout_active = 0;
			background1.audio.Stop();
		}

		//Handle background2 fade out
		background2.audio.volume = background2_vol;
		if (background2.audio.volume > 0 && background2_fadeout_active == 1) {
			background2_vol_fadeout ();
		} 
		if (background2.audio.volume <= 0) {
			background2_fadeout_active = 0;
			background2.audio.Stop();
		}

		
	}

	void FixedUpdate () {

//		//Handle background1 fade out
//		background1.audio.volume = background1_vol;
//		if (background1.audio.volume > 0 && background1_fadeout_active == 1) {
//			background1_vol_fadeout ();
//		} 
//		if (background1.audio.volume <= 0) {
//			background1_fadeout_active = 0;
//			background1.audio.Stop();
//		}
//		
//		//Handle background2 fade out
//		background2.audio.volume = background2_vol;
//		if (background2.audio.volume > 0 && background2_fadeout_active == 1) {
//			background2_vol_fadeout ();
//		} 
//		if (background2.audio.volume <= 0) {
//			background2_fadeout_active = 0;
//			background2.audio.Stop();
//		}
	}

	//Sound Effect Controllers
	public void soundEffect1_audio() {
		soundEffect1.audio.Play();
	}

	public void soundEffect2_audio() {
		soundEffect2.audio.Play();
	}

	public void soundEffect3_audio() {
		soundEffect3.audio.Play();
	}

	public void soundEffect4_audio() {
		soundEffect4.audio.Play();
	}

	public void soundEffect5_audio() {
		soundEffect5.audio.Play();
	}

	//Background Music Effects

	public void background1_audio() {
		background1.audio.Play();

	}

	//Background Music Fade out function
	public void background1_fadeout(){
		background1_fadeout_active = 1;
		background1_vol = 1.0f;
	}

	public void background2_audio() {
		background2.audio.Play();
	}

	//Background Fade out function
	public void background2_fadeout(){
		background2_fadeout_active = 1;
		background2_vol = 1.0f;
	}


	//Audio fadeout function

	void background1_vol_fadeout(){
		background1_vol = background1_vol - (0.5f*Time.deltaTime);
	}

	void background2_vol_fadeout(){
		background2_vol = background2_vol - (0.5f*Time.deltaTime);
	}

}

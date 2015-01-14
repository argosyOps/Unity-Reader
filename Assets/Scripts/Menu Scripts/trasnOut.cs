using UnityEngine;
using System.Collections;

public class trasnOut : MonoBehaviour {

	protected Animator animator;

	public void TriggerOut() {

		animator = GetComponent<Animator>();

		animator.SetBool("TransOut", true );


	}

}

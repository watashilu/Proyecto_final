
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour {

	private Animator anim;	
	private Rigidbody rb;

		// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		float verticalMovement = Input.GetAxisRaw ("Vertical");
		if (verticalMovement != 0.0f) {
			anim.SetBool ("IsWalking", true);
			anim.SetFloat ("speed", verticalMovement);

		} else {
			anim.SetBool ("IsWalking", false);
		}

		if (Input.GetKey ("space")) {
			anim.SetBool ("IsJumping", true);
		} else {
			anim.SetBool ("IsWalking", false);
		}

	}

	public void jump (){
		rb.AddForce (new Vector3 (0.0f, 10.0f, 0.0f), ForceMode.Impulse);
		anim.SetBool ("IsJumping", true);
	}

	void OnCollisionEnter (){
		anim.SetBool ("IsJumping", false);
	}
}
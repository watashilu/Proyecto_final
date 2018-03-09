
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimButtonController : MonoBehaviour {

	private Animator anim;	
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		

	}

	public void moveForward(){
		anim.SetBool ("IsWalking", true);
		anim.SetFloat ("speed", 1.0f);
	}

	public void moveBack(){
		anim.SetBool ("IsWalking", true);
		anim.SetFloat ("speed", 1.0f);
	}

	public void moveLeft(){
		anim.SetBool ("IsWalking", true);
		anim.SetFloat ("speed", 1.0f);
	}

	public void moveRight(){
		anim.SetBool ("IsWalking", true);
		anim.SetFloat ("speed", 1.0f);
	}


	public void stop(){
		anim.SetBool ("IsWalking", false);
	}


	public void jump (){
		rb.AddForce (new Vector3 (0.0f, 10.0f, 0.0f), ForceMode.Impulse);
		anim.SetBool ("IsJumping", true);
	}


}
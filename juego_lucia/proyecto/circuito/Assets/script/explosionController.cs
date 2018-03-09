﻿using System.Collections;
using UnityEngine;

public class explosionController : MonoBehaviour {

	public float impulse;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		this.rb = GetComponent<Rigidbody> ();
	}

	void OnCollisionEnter (Collision c){
		c.rigidbody.AddForce(c.transform.position, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

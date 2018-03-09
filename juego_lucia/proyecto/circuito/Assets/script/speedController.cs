using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedController : MonoBehaviour {

	public float impulse;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		this.rb = GetComponent<Rigidbody> ();
		
	}


	void OnCollisionExit (Collision c){
		c.rigidbody.AddForce (c.transform.position, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

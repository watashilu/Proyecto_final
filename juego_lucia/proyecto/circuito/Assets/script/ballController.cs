using UnityEngine;
using System.Collections;

public class ballController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	public GameObject Player;


	void Start () {
		this.rb = GetComponent<Rigidbody>();
		this.speed = 8;
	}


	void FixedUpdate () {
		float horizontalAxis = Input.GetAxis("Horizontal");
		float verticalAxis = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(horizontalAxis, 0.0f,verticalAxis);
		rb.AddForce(movement*speed);
	}



}



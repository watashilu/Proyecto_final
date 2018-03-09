using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigos : MonoBehaviour {

	public GameObject Player;
	private playerHealth playerHealth;
	int Damage;

	void Start (){
		Player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = Player.GetComponent<playerHealth> ();	

	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Player") {
			/*Damage(10);*/
		}

}

}

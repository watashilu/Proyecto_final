using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {

	public int maxHealth = 100;
	public int currentHealth;
	public int dmg = 20;
	public Text textsalud;



	void Awake (){

		currentHealth = maxHealth;
	}
		
	/*public void Damage (int dmg){
		currentHealth -= dmg;
	}*/

	void OnCollisionEnter (Collision col){
		Debug.Log ("hit");
		if (col.gameObject.tag == "obstaculo") {
			currentHealth -= dmg;
		}
	} 

	void Update ()
	{
		
	textsalud.text = (":" + currentHealth);
		if (currentHealth <= 0) {
			Die ();
		}
   }

    void Die (){

		SceneManager.LoadScene (1);

   }

}

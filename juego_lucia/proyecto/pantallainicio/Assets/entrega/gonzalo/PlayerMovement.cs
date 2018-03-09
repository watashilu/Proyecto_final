using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	void Update () {
		float verticalMovement = Input.GetAxis ("Vertical");
		float horizontalMovement = Input.GetAxis ("Horizontal");
		if (verticalMovement != 0.0f) {
			transform.Translate (transform.forward * verticalMovement * Time.deltaTime);
		}

	}
}

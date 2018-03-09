using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public GameObject MainMenuUI;

	public void juego()
	{
	
		SceneManager.LoadScene (1);

	}

	public void menu ()
	{

		SceneManager.LoadScene (0);

	}


	public void retry ()
	{

		SceneManager.LoadScene (1);

	}
}
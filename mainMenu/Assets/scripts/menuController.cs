using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour {
	
	//References. 
	[Header("References")]

	public GameObject root_holder;
	public GameObject settings_holder;
	[Tooltip("Index of scene to load when pressing play.")]
	public int start_level_index;



	//Loads the scene with index number set in "start_level_index" when start button is pushed.
	public void PlayButton () {

		SceneManager.LoadScene (start_level_index);

	}

	//Deactivates root menu and activates settings menu.
	public void SettingsButton () {

		root_holder.SetActive (false);
		settings_holder.SetActive (true);

	}

	//Closes the application.
	public void QuitButton () {

		Application.Quit ();

	}


	//Returns to root menu. 
	public void BackButton () {

		root_holder.SetActive (true);
		settings_holder.SetActive (false);

	}



}

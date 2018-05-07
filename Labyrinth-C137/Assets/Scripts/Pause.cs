using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

	[SerializeField]
	Transform canvas;

	void Update () {
		if (Input.GetButtonDown ("Cancel")) {
			PauseMenu ();
		}
	}

	public void PauseMenu()
	{
			if (canvas.gameObject.activeInHierarchy == false) {
				canvas.gameObject.SetActive (true);
				Time.timeScale = 0;

			} else {
				canvas.gameObject.SetActive (false);
				Time.timeScale = 1;
			}
	}

	public void LoadMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(0);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}

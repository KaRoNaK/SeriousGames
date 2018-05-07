using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colliding : MonoBehaviour {

	[SerializeField]
	private AudioSource oowee,pickle;



	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "Pickel_Rick 1") {
			pickle.Play ();
			StartCoroutine(delay ());


		} 
		else if (col.gameObject.name == "Mr.Puppy 1 1")
		{
			oowee.Play ();
			StartCoroutine(delay ());

		}
	}

	IEnumerator delay()
	{
		
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene (2);
	}
}

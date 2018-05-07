using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

	public GameObject cubePrefeb;

	void FixedUpdate()
	{
		Instantiate (cubePrefeb, transform.position, Quaternion.identity);
	}

}
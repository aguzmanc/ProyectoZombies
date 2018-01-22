using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour 
{
	void Start () 
	{
		StartCoroutine (Destruir ());
	}

	IEnumerator Destruir()
	{
		yield return new WaitForSeconds (5f);
		Destroy (gameObject);
	}
}

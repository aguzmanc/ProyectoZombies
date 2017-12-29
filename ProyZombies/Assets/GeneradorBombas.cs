using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBombas : MonoBehaviour {

	public GameObject BombPrototype;

	void Start () {
		StartCoroutine (Generar ());
	}
	

	void Update () {
		
	}

	IEnumerator Generar(){
		while (true) {
			yield return new WaitForSeconds (5);
			Instantiate (BombPrototype, transform.position, Quaternion.identity);
		}
		
	}
}

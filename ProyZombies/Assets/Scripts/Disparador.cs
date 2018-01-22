using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour {

	public GameObject Bala;

	public void Disparar() {
		Instantiate (Bala, transform.position + new Vector3(0, 0, 1f), transform.rotation);
	}
}

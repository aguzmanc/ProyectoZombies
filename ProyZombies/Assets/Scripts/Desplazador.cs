using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desplazador : MonoBehaviour {

	public float VelocidadGiro = 3.75f;
	public float VelocidadCaminar = 0.05f;

	public bool adelante;
	public bool derecha;
	public bool izquierda;
	public bool atras;

	Rigidbody _rb;

	// Use this for initialization
	void Start () {
		_rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (derecha) {
			Vector3 v = new Vector3 (0, VelocidadGiro, 0);
			_rb.transform.Rotate (v);
		}
		if (izquierda) {
			_rb.transform.Rotate (0, -VelocidadGiro, 0);
		}
		if (adelante) {
			_rb.transform.Translate (0, 0, VelocidadCaminar);
		}

		if (atras) {
			_rb.transform.Translate (0, 0, -VelocidadCaminar);
		}
	}
}

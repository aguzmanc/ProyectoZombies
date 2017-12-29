using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inversor : MonoBehaviour {

	public float TiempoInversion = 1.5f;
	public float _tiempoRestante;
	Enemigo _enemigoScript;

	// Use this for initialization
	void Start () {
		_enemigoScript = GetComponent<Enemigo> ();
	}
	
	// Update is called once per frame
	void Update () {
		_tiempoRestante = _tiempoRestante - Time.deltaTime;
		if (_tiempoRestante <= 0) {
			_tiempoRestante = TiempoInversion;
			_enemigoScript.direccion = !_enemigoScript.direccion;
			transform.Rotate (0, 180, 0);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour 
{
	public float VelocidadAvance = 0.1f;
	public float TiempoPatrulla = 1.5f;
	public float _tiempoRestante;
	public int NumeroLados = 5;
	public bool direccion = true;

	public bool _siguiendo = false;
	public Transform _objetivo;

	void Start () 
	{
		_tiempoRestante = TiempoPatrulla;
	}

	void Update () 
	{
		if (!_siguiendo) {
			Patrullar();
		} else {
			Seguir();
		}
		
	}

	void Patrullar() {
		_tiempoRestante = _tiempoRestante - Time.deltaTime;
		if (_tiempoRestante <= 0) {
			_tiempoRestante = TiempoPatrulla;
			transform.Rotate (0, (direccion? 1 : -1)*360/NumeroLados, 0);
		}

		transform.Translate (0, 0,VelocidadAvance);
	}

	void Seguir() {
		transform.LookAt (_objetivo.position);
		transform.Translate (0, 0, VelocidadAvance);
	}

	public void EmpezarASeguir(Transform t) {
		_siguiendo = true;
		_objetivo = t;
	}

	public void PararDeSeguir() {
		_siguiendo = false;
	}
}

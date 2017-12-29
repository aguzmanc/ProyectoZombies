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

	void Start () 
	{
		_tiempoRestante = TiempoPatrulla;
	}

	void Update () 
	{
		_tiempoRestante = _tiempoRestante - Time.deltaTime;
		if (_tiempoRestante <= 0) {
			_tiempoRestante = TiempoPatrulla;
			transform.Rotate (0, (direccion? 1 : -1)*360/NumeroLados, 0);
		}

		transform.Translate (0, 0,VelocidadAvance);
	}
}

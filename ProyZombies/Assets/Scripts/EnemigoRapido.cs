using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoRapido : MonoBehaviour
{
	public int LadosPoligono;
	public float TiempoGiro;
	public float TiempoVoltear;
	public bool _sentido;

	void Start ()
	{
		StartCoroutine (MiPrimeraCorutina ());
		StartCoroutine (Voltear ());
		_sentido = true;
	}
	
	void Update () 
	{
		transform.Translate (0, 0, 0.1f);
	}


	IEnumerator MiPrimeraCorutina()
	{
		while (true) {
			yield return new WaitForSeconds (TiempoGiro);
			transform.Rotate (0,(_sentido ? 1 : -1) * (360f/LadosPoligono), 0);
		}
	}

	IEnumerator Voltear()
	{
		while (true) {
			yield return new WaitForSeconds (TiempoVoltear);
			transform.Rotate (0, 180, 0);
			_sentido = !_sentido; 

		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour 
{
	[HideInInspector]
	public bool EstaAbierta;

	public float LimiteAltura = 7f;
	public float VelocidadSubida = 0.1f;

	void Start () 
	{
		EstaAbierta = false;
		StartCoroutine (_CorutinaPuerta ());
	}
	
	void Update () 
	{
		if(EstaAbierta)
			transform.Translate (0, VelocidadSubida, 0);
	}

	IEnumerator _CorutinaPuerta() 
	{
		// esperar para que este abierta
		yield return new WaitUntil( () => {return EstaAbierta;});

		yield return new WaitWhile( () => {return (transform.position.y < LimiteAltura);} );

		EstaAbierta = false;
	}
}

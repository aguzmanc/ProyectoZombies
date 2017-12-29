using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguidor : MonoBehaviour 
{
	public GameObject Jugador;

	Vector3 _dif;

	void Start () 
	{
		_dif = Jugador.transform.position - transform.position;
	}
	
	void Update () 
	{
		transform.position = Jugador.transform.position - _dif;
	}
}

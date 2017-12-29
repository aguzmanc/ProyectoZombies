using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiScript : MonoBehaviour 
{
	[Tooltip("Esto es la velocidad")]
	[Range(-0.3f, 0.3f)]
	public float Velocidad = 0.1f;


	float x;

	void Start () 
	{
	}
	

	void Update () 
	{
		x += Velocidad;
		Vector3 v = new Vector3 (x,0,0);
		transform.position = v;
	}
}

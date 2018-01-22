using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruido : MonoBehaviour 
{
	[Range(0, 0.1f)]
	public float Velocidad = 0;

	[Range(0,20)]
	public float X=0;

	[Range(-5,5)]
	public float VarMax=3;
	[Range(-5,5)]
	public float VarMin=1;

	
	void Update () 
	{
		X = X + Velocidad;

		float y = Mathf.PerlinNoise (0, X) * (VarMax-VarMin) + VarMin;

		transform.position = new Vector3 (0, y, 0);
	}
}

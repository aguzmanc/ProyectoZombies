using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour 
{
	public Vector3 Velocidad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//transform.Rotate (Velocidad.x, Velocidad.y, Velocidad.z, Space.World);
		transform.Translate(0,0,0.1f, Space.World);
		
	}
}

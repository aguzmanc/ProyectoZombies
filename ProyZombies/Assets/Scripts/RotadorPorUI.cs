using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotadorPorUI : MonoBehaviour 
{
	bool _estaRotando;

	public bool EstaRotando 
	{
		get{ 
			return _estaRotando; 
		}


		set{ _estaRotando = value; }
	}




	void Start () 
	{
		_estaRotando = false;
	}
	
	void Update () 
	{
		if(_estaRotando)
			transform.Rotate (0, 1, 0);
		
	}
}

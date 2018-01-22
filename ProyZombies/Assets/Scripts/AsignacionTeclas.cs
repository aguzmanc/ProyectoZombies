using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsignacionTeclas : MonoBehaviour {

	Desplazador desplazador;

	// Use this for initialization
	void Start () {
		desplazador = GetComponent<Desplazador> ();
	}
	
	// Update is called once per frame
	void Update () {
		desplazador.adelante = Input.GetKey (KeyCode.UpArrow);
		desplazador.derecha = Input.GetKey (KeyCode.RightArrow);
		desplazador.izquierda = Input.GetKey (KeyCode.LeftArrow);
		desplazador.atras = Input.GetKey (KeyCode.DownArrow);
	}
}

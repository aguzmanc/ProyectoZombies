using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputUI : MonoBehaviour {

	Desplazador _desplazador;
	Disparador _disparador;

	void Start() {
		_desplazador = GetComponent<Desplazador> ();
		_disparador = GetComponent<Disparador> ();
	}

	public void irAtras() {
		parar ();
		_desplazador.atras = true;
	}

	 public void irAdelante() {
		parar ();
		_desplazador.adelante = true;
	}

	public void rotarIzquierda() {
		parar ();
		_desplazador.izquierda = true;
	}

	public void rotarDerecha() {
		parar ();
		_desplazador.derecha = true;
	}

	public void parar() {
		_desplazador.adelante = false;
		_desplazador.atras = false;
		_desplazador.derecha = false;
		_desplazador.izquierda = false;
	}

	public void Disparar() {
		_disparador.Disparar ();
	}
}

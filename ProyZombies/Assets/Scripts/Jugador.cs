using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
	public float VelocidadGiro = 3.75f;
	public float VelocidadCaminar = 0.05f;
	public float VelocidadCorrer = 0.12f;
	public Transform PosicionInicial;
	public bool Joystick = true;
	Rigidbody _rb;

	void Start () 
	{
		_rb = GetComponent<Rigidbody> ();
	}

	public float Fuerza = 1;

	void FixedUpdate () 
	{
		if (Joystick) {
			float h = Input.GetAxis ("Horizontal");
			float v = Input.GetAxis ("Vertical");

			_rb.transform.Rotate (0, h * 5, 0, Space.World);

			//missing input for run
			//bool correr = Input.GetKey (KeyCode.LeftShift);
			//if (correr)
			//	_rb.transform.Translate (0, 0, v/2);
			//else
			_rb.transform.Translate (0, 0, 0.3f * v, Space.Self);
			
			//missing input for jump
			//if (Input.GetKeyDown (KeyCode.Space))
			//	_rb.AddForce (0, Fuerza, 0);
		} else {
			bool adelante = Input.GetKey (KeyCode.UpArrow);
			bool derecha = Input.GetKey (KeyCode.RightArrow);
			bool izquierda = Input.GetKey (KeyCode.LeftArrow);
			bool correr = Input.GetKey (KeyCode.LeftShift);
			bool atras = Input.GetKeyDown (KeyCode.DownArrow);

			float velocidadDesplazamiento = correr ? VelocidadCorrer : VelocidadCaminar;

			if (derecha) {
				Vector3 v = new Vector3 (0, VelocidadGiro, 0);
				_rb.transform.Rotate (v);
			}
			if (izquierda) {
				_rb.transform.Rotate (0, -VelocidadGiro, 0);
			}
			if (adelante) {
				_rb.transform.Translate (0, 0, velocidadDesplazamiento);
			}

			if (atras) {
				_rb.transform.Rotate (0, 180, 0);
			}

			if (Input.GetKeyDown (KeyCode.Space)) {
				_rb.AddForce (0, Fuerza, 0);
			}
		}
	}

	void OnTriggerEnter(Collider otro){
		if (otro.tag == "Enemigo") {
			transform.position = PosicionInicial.position;
		}
	}
}

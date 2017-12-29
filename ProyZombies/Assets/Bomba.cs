using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour 
{
	Rigidbody _rb;
	GameObject _jugador;

	public float Fuerza = 100;
	public float radio = 10;
	public GameObject ExplosionPrototipe;


	void OnTriggerEnter(Collider otro)
	{
		if (otro.tag == "Player") {
			_jugador = otro.gameObject;
			StartCoroutine (Explotar ());
		}
	}


	IEnumerator Explotar()
	{
		yield return new WaitForSeconds (0);
		
		Rigidbody rb = _jugador.GetComponent<Rigidbody> ();
		rb.AddExplosionForce (Fuerza, transform.position, radio);
		rb.constraints = RigidbodyConstraints.None;
		rb.AddTorque (20, 3, 40);

		Instantiate (ExplosionPrototipe, transform.position, Quaternion.identity); 
		Destroy (gameObject);
	}
}

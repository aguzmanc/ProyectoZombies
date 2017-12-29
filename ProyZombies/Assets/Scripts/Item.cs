using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour 
{
	public GameObject Target;
	public Puerta Puerta;

	void OnTriggerEnter(Collider otro) 
	{
		if (otro.tag == "Player") {
			Destroy (gameObject);

			otro.GetComponent<Renderer> ().material.color = Color.green;
			Puerta.EstaAbierta = true;
		}
	}
}

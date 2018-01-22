using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
	Enemigo _enemigo;

	[Range(1,60)]
	public int GradosVision = 1;
	[Range(0,1f)]
	public float Precision = 1;

	public float Alcance = 5;
	bool siguiendo;
	Transform target;

	void Start() {
		_enemigo = GetComponent<Enemigo> ();
	}
	
	void Update () 
	{
		if (Precision > 0) {
			siguiendo = false;
			for (float i = -GradosVision; i <= GradosVision; i += Precision)
				Detectar (new Ray (transform.position, Quaternion.Euler (0, i, 0) * transform.forward));
			if (siguiendo)
				_enemigo.EmpezarASeguir (target);
		}
	}

	void Detectar(Ray ray)
	{
		RaycastHit hit;
		Color c = Color.red;

		if (Physics.Raycast (ray, out  hit, Alcance)) {

			if (hit.collider.tag == "Player") {
				c = Color.green;
				//_enemigo.EmpezarASeguir (hit.collider.transform);
				siguiendo = true;
				target = hit.collider.transform;
			}
		}


		Debug.DrawRay (ray.origin, ray.direction * Alcance, c);
	}
}

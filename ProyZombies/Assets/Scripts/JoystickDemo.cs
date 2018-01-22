using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickDemo : MonoBehaviour {

	void Start () {
		
	}


	void Update () 
	{
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		transform.Rotate (0, h * 5, 0, Space.World);

		transform.Translate (0, 0.3f * v, 0, Space.Self);
	}
}

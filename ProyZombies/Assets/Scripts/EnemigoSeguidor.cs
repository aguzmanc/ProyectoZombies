using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoSeguidor : MonoBehaviour {

	public Transform Player;

	void Start () {
		
	}

	void Update () {
		transform.position = new Vector3(Player.position.x, transform.position.y, Player.position.z);
	}
}

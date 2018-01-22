using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Follower : MonoBehaviour {

	public RectTransform piter;
	public RectTransform spuderman;
	public RectTransform rodri;
	public RectTransform[] positions;
	public int posZzX;
	public int posZzY;
	public int dirZz;

	// Use this for initialization
	void Start () {
		changePosition (piter, 0, 0);
		changePosition (spuderman, 0, 0);
		changePosition (rodri, 0, 1);
		StartCoroutine (moveHorizontally(0, 0));
		StartCoroutine (moveJumpedVertically(0, 0));
		StartCoroutine (moveZigzag(0, 1));
	}
	
	// Update is called once per frame
	void Update () {
		//changePosition ();
	}

	void changePosition(RectTransform rt, int posX, int posY) {
		int position = posX * 5 + posY;
		rt.SetParent(positions [position]);
		rt.offsetMax = new Vector2(0, 0);
		rt.offsetMin = new Vector2(0, 0);
	}

	IEnumerator moveHorizontally(int posX, int posY) {
		
		while (true) {
			yield return new WaitForSeconds (1f);
			posX = (posX + 1) % 5;
			changePosition (piter, posX, posY);
		}
	}

	IEnumerator moveJumpedVertically(int posX, int posY) {
		while (true) {
			yield return new WaitForSeconds (1f);
			posY = (posY + 1) % 5;
			posX = posY == 0 ? (posX + 1) % 5 : posX;
			changePosition (spuderman, posX, posY);
		}
	}

	IEnumerator moveZigzag(int posX, int posY) {
		int dir = 1;
		while (true) {
			yield return new WaitForSeconds (1f);
			posX += dir;
			if (posX < 0 || posX > 4) {
				dir *= -1;
				posX += dir;
				posY = (posY + 1) % 5;
			}
			changePosition (rodri, posX, posY);
		}
	}
}

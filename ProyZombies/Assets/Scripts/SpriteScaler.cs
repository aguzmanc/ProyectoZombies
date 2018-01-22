using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteScaler : MonoBehaviour {

	public RectTransform YScale;
	public RectTransform XScale;

	float _width;
	float _height;
	RectTransform _transform;

	// Use this for initialization
	void Start () {
		_transform = GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update () {
		_width = XScale.rect.width;
		_height = YScale.rect.height;
		if (_width > _height) {
			_transform.SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, _height);
			_transform.SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, _height);
		} else {
			_transform.SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, _width);
			_transform.SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, _width);
		}
	}
}

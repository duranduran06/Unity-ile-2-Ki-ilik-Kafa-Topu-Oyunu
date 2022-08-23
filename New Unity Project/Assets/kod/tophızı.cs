using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tophızı : MonoBehaviour {
	public Vector2 basla;
	// Use this for initialization
	void Start () {

		Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
		rigidbody.AddForce(basla, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

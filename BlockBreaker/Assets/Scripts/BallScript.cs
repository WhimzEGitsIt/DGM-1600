using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	float BallForce = 200f;
	// Use this for initialization
	void Start () {
		Rigidbody ballrig = GetComponent<Rigidbody> ();
		ballrig.AddForce (0, BallForce, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public float paddleSpeed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (paddleSpeed * Time.deltaTime * Input.GetAxis ("Horizontal"), 0, 0);
		float xPos = transform.position.x + (Input.GetAxis ("Horizontal") * paddleSpeed);
		var pos = transform.position;
		pos.x = Mathf.Clamp (xPos, -13.5f, 13.5f);
		transform.position = pos;
	}

	void OnCollisionEnter (Collision col) {
		foreach (ContactPoint contact in col.contacts) {
			if (contact.thisCollider == GetComponent<BoxCollider>()) {
				float calc = contact.point.x - transform.position.x;

				contact.otherCollider.GetComponent<Rigidbody> ().AddForce (400f * calc, 0, 0);
			}
		}
	}

}


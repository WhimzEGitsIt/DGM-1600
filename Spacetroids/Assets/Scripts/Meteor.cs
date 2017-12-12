using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {




	public float startingSpin;
	public int health;
	private int count =0; 
	private LevelManager levelManager;

	void Start () {
		levelManager = FindObjectOfType<LevelManager> ();
		GetComponent<Rigidbody2D> ().AddTorque (Random.Range(-startingSpin,startingSpin), ForceMode2D.Impulse);
	}

	void OnCollisionEnter2D (Collision2D collider) {
		health--;
		count++;

		if (health <= 0) {
		Destroy (this.gameObject);
		}
	}

}


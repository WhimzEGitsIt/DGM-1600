using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazorScript : MonoBehaviour {


	public float lifetime;
	public float speed;




	void Start () {
		
	}
	

	void Update () {
	

		lifetime -= Time.deltaTime;
		if (lifetime <= 0) {
			Destroy (this.gameObject);
		}

		//transform.Translate (Vector3.up * speed * Time.deltaTime);

	}
}
